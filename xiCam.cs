using System;
using System.Text;
using System.Runtime.InteropServices;
using xiApi;

namespace XimeaWrapper
{
  // xiApi.NET.xiCam

  /// <summary>
  /// Contains function definitions for the camera xiAPI.NET class.
  /// </summary>
  public class xiCam
  {
    /// <summary>
    /// OpenDevice function paramameter enumerator, provides options to be used for selecting the appropriate 
    /// camera to be opened.
    /// </summary>
    public enum OpenDevBy
    {
      /// <summary>Open camera by its index.</summary>
      Index,
      /// <summary>Open camera by its serial number.</summary>
      SerialNumber,
      /// <summary>Open camera by its system instance path.</summary>
      SystemInstancePath,
      /// <summary>Open camera by its user ID string.</summary>
      DeviceUserId
    }

    private const int XI_OK = 0;

    private UIntPtr handle;

    private int isColor;

    private ImgParams img_params = new ImgParams();

    /// <summary>
    /// Class contructor, initializes class variables.
    /// </summary>
    public xiCam()
    {
      handle = UIntPtr.Zero;
      isColor = 0;
    }

    /// <summary>
    /// Class destructor, unitializes class variables.
    /// </summary>
    ~xiCam()
    {
    }

    /// <summary>
    /// Returns the number of all discovered devices.
    /// </summary>
    /// <param name="devCount">The number of connected devices.</param>
    public unsafe void GetNumberDevices(out int devCount)
    {
      int num = 0;
      fixed (int* numDevices = &devCount)
      {
        num = ximeaApi.xiGetNumberDevices(numDevices);
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetNumberDevices");
      }
    }

    /// <summary>
    /// Returns the number of all discovered devices.
    /// </summary>
    /// <returns>The number of connected devices.</returns>
    public unsafe int GetNumberDevices()
    {
      int num = 0;
      int result = 0;
      num = ximeaApi.xiGetNumberDevices(&result);
      if (num != 0)
      {
        throw new xiExc(num, "GetNumberDevices");
      }
      return result;
    }

    /// <summary>
    /// This function initializes the device.
    /// </summary>
    /// <param name="DevID">Index of the device</param>
    public void OpenDevice(int DevID)
    {
      OpenDevice(OpenDevBy.Index, DevID.ToString());
    }

    /// <summary>
    /// This function initializes the device.
    /// </summary>
    /// <param name="Open_By">Method to be used when selecting the device to be opened, use OpenDevBy enumerator for selection.</param>
    /// <param name="Param">Input parameter for device selection, e.g. serial number or instance path.</param>
    public unsafe void OpenDevice(OpenDevBy Open_By, string Param)
    {
      int num = 0;
      int num2 = -1;
      switch (Open_By)
      {
        case OpenDevBy.Index:
          num2 = Convert.ToInt32(Param);
          break;
        case OpenDevBy.SerialNumber:
          {
            xiCamEnum xiCamEnum2 = new xiCamEnum();
            for (int j = 0; j < xiCamEnum2.ReEnumerate(); j++)
            {
              if (xiCamEnum2.GetSerialNumById(j).Equals(Param))
              {
                num2 = j;
                break;
              }
            }
            break;
          }
        case OpenDevBy.SystemInstancePath:
          {
            xiCamEnum xiCamEnum3 = new xiCamEnum();
            for (int k = 0; k < xiCamEnum3.ReEnumerate(); k++)
            {
              if (xiCamEnum3.GetInstancePathById(k).Equals(Param))
              {
                num2 = k;
                break;
              }
            }
            break;
          }
        case OpenDevBy.DeviceUserId:
          {
            xiCamEnum xiCamEnum = new xiCamEnum();
            for (int i = 0; i < xiCamEnum.ReEnumerate(); i++)
            {
              if (xiCamEnum.GetDeviceUserIdById(i).Equals(Param))
              {
                num2 = i;
                break;
              }
            }
            break;
          }
        default:
          throw new xiExc(11, "OpenDevice");
      }
      if (num2 < 0)
      {
        throw new xiExc(56, "OpenDevice");
      }
      try
      {
        void* value = null;
        num = ximeaApi.xiOpenDevice(num2, &value);
        handle = new UIntPtr(value);
        isColor = GetParamInt("iscolor");
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "OpenDevice");
      }
    }

    /// <summary>
    /// This function uninitializes the specified device
    /// and releases allocated resources.
    /// </summary>
    public unsafe void CloseDevice()
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiCloseDevice((void*)handle);
      }
      catch
      {
        num = 0;
      }
      handle = UIntPtr.Zero;
      if (num != 0)
      {
        throw new xiExc(num, "CloseDevice");
      }
    }

    /// <summary>
    /// This function starts the data acquisition on the device.
    /// </summary>
    public unsafe void StartAcquisition()
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiStartAcquisition((void*)handle);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "StartAcquisition");
      }
    }

    /// <summary>
    /// This function stops the work cycle and data acquisition on the device.
    /// </summary>
    public unsafe void StopAcquisition()
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiStopAcquisition((void*)handle);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "StopAcquisition");
      }
    }

    /// <summary>
    /// Internal handler of xiGetImage for all instances in class.
    /// </summary>
    /// <param name="input_img">XI_IMG structure to be filled</param>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    internal unsafe XI_IMG GetImageInternal(XI_IMG input_img, int timeout)
    {
      int num = 0;
      XI_IMG xI_IMG = input_img;
      try
      {
        num = ximeaApi.xiGetImage((void*)handle, timeout, &xI_IMG);
      }
      catch (AccessViolationException)
      {
        throw new xiExc(9, "GetImage");
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetImage");
      }
      img_params.UpdateValues(xI_IMG);
      return xI_IMG;
    }

    /// <summary>
    /// This function returnes number if pixels in image according to format, width and height.
    /// </summary>
    /// <param name="pf">Image data format in integer format</param>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <returns>Number of pixels in the image based on dimensions and data format</returns>
    internal int GetNumPixelsInternal(int pf, int width, int height)
    {
      switch (pf)
      {
        case 0:
        case 5:
          return width * height;
        case 1:
        case 6:
          return width * 2 * height;
        case 2:
        case 4:
          if (isColor == 1)
          {
            return width * 3 * height;
          }
          return width * height;
        case 3:
          if (isColor == 1)
          {
            return width * 4 * height;
          }
          return width * height;
        default:
          throw new xiExc(108, "GetNumPixelsInternal");
      }
    }

    ///// <summary>
    ///// This function returnes number if pixels in image according to format, width and height.
    ///// </summary>
    ///// <param name="pf">Image data format in integer format</param>
    ///// <returns>Dot NET pixel format appropriate to the selected data format</returns>
    //internal PixelFormat XiDataFormatToNETPixelFormatInternal(int pf)
    //{
    //  PixelFormat pixelFormat = PixelFormat.Undefined;
    //  switch (pf)
    //  {
    //    case 0:
    //    case 5:
    //      return PixelFormat.Format8bppIndexed;
    //    case 1:
    //    case 6:
    //      return PixelFormat.Format16bppGrayScale;
    //    case 2:
    //    case 4:
    //      return PixelFormat.Format24bppRgb;
    //    case 3:
    //      return PixelFormat.Format32bppRgb;
    //    default:
    //      throw new xiExc(108, "XiDataFormatToNETPixelFormatInternal");
    //  }
    //}

    /// <summary>
    /// This function acquires image and returns XI_IMG structure.
    /// </summary>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    /// <returns>XI_IMG structure with information about acquired image.</returns>
    public XI_IMG GetXI_IMG(int timeout)
    {
      XI_IMG image = default(XI_IMG);
      image.Clear();
      GetXI_IMG(ref image, timeout);
      return image;
    }

    /// <summary>
    /// This function acquires image and returns XI_IMG structure.
    /// </summary>
    /// <param name="image">XI_IMG structure to be filled</param>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    public void GetXI_IMG(ref XI_IMG image, int timeout)
    {
      image = GetImageInternal(image, timeout);
    }

    ///// <summary>
    ///// This function acquires image and returns fills BitmapSource object.
    ///// </summary>
    ///// <param name="image">WPF BitmapSource to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void GetImage(out BitmapSource image, int timeout)
    //{
    //  if (GetParamInt("buffer_policy") == 0)
    //  {
    //    XI_IMG input_img = default(XI_IMG);
    //    input_img.Clear();
    //    input_img = GetImageInternal(input_img, timeout);
    //    xiImg xiImg = new xiImg(input_img);
    //    xiImg.GetBitmapSourceByRef(out image);
    //    return;
    //  }
    //  throw new xiExc(106, "ERROR: This function supports only UNSAFE buffer policy(BUFF_POLICY.UNSAFE).");
    //}

    ///// <summary>
    ///// This function acquires image and returns fills WritableBitmap object. Supports UNSAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">WPF WriteableBitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void GetWriteableBitmapRef(out WriteableBitmap image, int timeout)
    //{
    //  GetImage(out image, timeout);
    //}

    ///// <summary>
    ///// This function acquires image and returns fills WritableBitmap object. Supports UNSAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">WPF WriteableBitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void GetImage(out WriteableBitmap image, int timeout)
    //{
    //  if (GetParamInt("buffer_policy") == 0)
    //  {
    //    XI_IMG input_img = default(XI_IMG);
    //    input_img.Clear();
    //    input_img = GetImageInternal(input_img, timeout);
    //    xiImg xiImg = new xiImg(input_img);
    //    xiImg.GetWriteableBitmapByRef(out image);
    //    return;
    //  }
    //  throw new xiExc(106, "ERROR: This function supports only UNSAFE buffer policy(BUFF_POLICY.UNSAFE).");
    //}

    ///// <summary>
    ///// This function acquires image and returns fills WritableBitmap object. Supports SAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">WPF WriteableBitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void GetWriteableBitmap(WriteableBitmap image, int timeout)
    //{
    //  GetImage(image, timeout);
    //}

    ///// <summary>
    ///// This function acquires image and returns fills WritableBitmap object. Supports SAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">WPF WriteableBitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public unsafe void GetImage(WriteableBitmap image, int timeout)
    //{
    //  int paramInt = GetParamInt("buffer_policy");
    //  int paramInt2 = GetParamInt("imgdataformat");
    //  if (paramInt == 1)
    //  {
    //    XI_IMG input_img = default(XI_IMG);
    //    input_img.Clear();
    //    input_img.bp_size = GetNumPixelsInternal(paramInt2, Convert.ToInt32(image.Width), Convert.ToInt32(image.Height));
    //    image.Lock();
    //    input_img.bp = (void*)image.BackBuffer;
    //    input_img = GetImageInternal(input_img, timeout);
    //    image.Unlock();
    //    return;
    //  }
    //  throw new xiExc(106, "ERROR: This function supports only UNSAFE buffer policy(BUFF_POLICY.SAFE).");
    //}

    /// <summary>
    /// This function acquires image into a byte array. Supports UNSAFE and SAFE buffer policy mode.
    /// Image formats IMG_FORMAT.RAW16 and IMG_FORMAT.MONO16 are not supported.
    /// </summary>
    /// <param name="img_arr">Preallocated byte array to be filled</param>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    public void GetImageByteArray(byte[] img_arr, int timeout)
    {
      GetImage(img_arr, timeout);
    }

    /// <summary>
    /// This function acquires image into a byte array. Supports UNSAFE buffer policy mode.
    /// </summary>
    /// <param name="img_arr">Preallocated byte array to be filled</param>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    public void GetImage(out byte[] img_arr, int timeout)
    {
      XI_IMG input_img = default(XI_IMG);
      input_img.Clear();
      input_img = GetImageInternal(input_img, timeout);
      xiImg xiImg = new xiImg(input_img);
      xiImg.GetByteArrayByRef(out img_arr);
    }

    /// <summary>
    /// This function acquires image into a byte array. Supports SAFE buffer policy mode.        
    /// </summary>
    /// <param name="img_arr">Preallocated byte array to be filled</param>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    public unsafe void GetImage(byte[] img_arr, int timeout)
    {
      if (img_arr == null)
      {
        throw new xiExc(11, "GetImage");
      }
      int paramInt = GetParamInt("buffer_policy");
      if (paramInt == 1)
      {
        XI_IMG input_img = default(XI_IMG);
        input_img.Clear();
        fixed (byte* bp = &img_arr[0])
        {
          input_img.bp = bp;
        }
        input_img.bp_size = img_arr.Length;
        input_img = GetImageInternal(input_img, timeout);
        return;
      }
      throw new xiExc(106, "ERROR: This function supports only UNSAFE buffer policy(BUFF_POLICY.SAFE).");
    }

    ///// <summary>
    ///// This function acquires image and returns fills bitmap object. Supports UNSAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">GDI+ bitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void GetBitmapRef(out Bitmap image, int timeout)
    //{
    //  GetImage(out image, timeout);
    //}

    ///// <summary>
    ///// This function acquires image and returns fills bitmap object. Supports UNSAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">GDI+ bitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void GetImage(out Bitmap image, int timeout)
    //{
    //  if (GetParamInt("buffer_policy") == 0)
    //  {
    //    XI_IMG input_img = default(XI_IMG);
    //    input_img.Clear();
    //    input_img = GetImageInternal(input_img, timeout);
    //    xiImg xiImg = new xiImg(input_img);
    //    xiImg.GetBitmapByRef(out image);
    //    return;
    //  }
    //  throw new xiExc(106, "ERROR: This function supports only UNSAFE buffer policy(BUFF_POLICY.UNSAFE).");
    //}

    ///// <summary>
    ///// This function acquires image and returns fills bitmap object. Supports SAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">GDI+ bitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void GetBitmap(Bitmap image, int timeout)
    //{
    //  GetImage(image, timeout);
    //}

    ///// <summary>
    ///// This function acquires image and returns fills bitmap object. Supports SAFE buffer policy mode.
    ///// </summary>
    ///// <param name="image">GDI+ bitmap to be filled</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public unsafe void GetImage(Bitmap image, int timeout)
    //{
    //  int paramInt = GetParamInt("buffer_policy");
    //  int paramInt2 = GetParamInt("imgdataformat");
    //  if (paramInt == 1)
    //  {
    //    XI_IMG input_img = default(XI_IMG);
    //    input_img.Clear();
    //    PixelFormat pixelFormat = XiDataFormatToNETPixelFormatInternal(paramInt2);
    //    input_img.bp_size = GetNumPixelsInternal(paramInt2, image.Width, image.Height);
    //    BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, pixelFormat);
    //    input_img.bp = bitmapData.Scan0.ToPointer();
    //    try
    //    {
    //      input_img = GetImageInternal(input_img, timeout);
    //    }
    //    catch (xiExc exc)
    //    {
    //      image.UnlockBits(bitmapData);
    //      throw new xiExc(exc);
    //    }
    //    image.UnlockBits(bitmapData);
    //    if (pixelFormat == PixelFormat.Format8bppIndexed)
    //    {
    //      ColorPalette palette = image.Palette;
    //      for (int i = 0; i <= 255; i++)
    //      {
    //        palette.Entries[i] = Color.FromArgb(i, i, i);
    //      }
    //      image.Palette = palette;
    //    }
    //    return;
    //  }
    //  throw new xiExc(106, "ERROR: This function supports only UNSAFE buffer policy(BUFF_POLICY.UNSAFE).");
    //}

    /// <summary>
    /// This function returns more detailed information about the last image in the ImgParams object
    /// </summary>
    public ImgParams GetLastImageParams()
    {
      return img_params;
    }

    /// <summary>
    /// This function configures the device. 
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to set parameters.</param>
    /// <param name="val">Integer value to be set.</param>
    public unsafe void SetParam(string prm, int val)
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiSetParam((void*)handle, prm, &val, 4, PRM_TYPE.TypeInteger);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "SetParam " + prm);
      }
    }

    /// <summary>
    /// This function configures the device.
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to set parameters.</param>
    /// <param name="val">Float value to be set.</param>
    public unsafe void SetParam(string prm, float val)
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiSetParam((void*)handle, prm, &val, 4, PRM_TYPE.TypeFloat);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "SetParam " + prm);
      }
    }

    /// <summary>
    /// This function configures the device. 
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to set parameters.</param>
    /// <param name="val">String value to be set.</param>
    public unsafe void SetParam(string prm, string val)
    {
      int num = 0;
      PRM_TYPE type = PRM_TYPE.TypeString;
      if (val.Length == 0)
      {
        throw new xiExc(101, "SetParam " + prm);
      }
      try
      {
        byte[] bytes = Encoding.ASCII.GetBytes(val);
        IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);
        num = ximeaApi.xiSetParam((void*)handle, prm, intPtr.ToPointer(), val.Length, type);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "SetParam " + prm);
      }
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <param name="val">Integer value to be returned.</param>
    public unsafe void GetParam(string prm, out int val)
    {
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeInteger;
      int num = 0;
      int num2 = 4;
      val = 0;
      try
      {
        try
        {
          fixed (int* val2 = &val)
          {
            num = ximeaApi.xiGetParam((void*)handle, prm, val2, &num2, &pRM_TYPE);
          }
        }
        finally
        {
        }
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetParam " + prm);
      }
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <returns>Integer value to be returned.</returns>
    public unsafe int GetParamInt(string prm)
    {
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeInteger;
      int num = 0;
      int num2 = 4;
      int result = 0;
      try
      {
        num = ximeaApi.xiGetParam((void*)handle, prm, &result, &num2, &pRM_TYPE);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetParam " + prm);
      }
      return result;
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <param name="val">Float value to be returned.</param>
    public unsafe void GetParam(string prm, out float val)
    {
      int num = 0;
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeFloat;
      int num2 = 4;
      val = 0f;
      try
      {
        try
        {
          fixed (float* val2 = &val)
          {
            num = ximeaApi.xiGetParam((void*)handle, prm, val2, &num2, &pRM_TYPE);
          }
        }
        finally
        {
        }
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetParam " + prm);
      }
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <returns>Float value to be returned.</returns>
    public unsafe float GetParamFloat(string prm)
    {
      int num = 0;
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeFloat;
      int num2 = 4;
      float result = 0f;
      try
      {
        num = ximeaApi.xiGetParam((void*)handle, prm, &result, &num2, &pRM_TYPE);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetParam " + prm);
      }
      return result;
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <param name="val">Byte array value to be returned.</param>
    /// <param name="val_len">Byte array lenght to be returned.</param>
    public unsafe void GetParam(string prm, out byte[] val, out int val_len)
    {
      int num = 0;
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeString;
      int num2 = 1;
      val_len = 0;
      val = new byte[0];
      try
      {
        ximeaApi.xiGetParam((void*)handle, prm, null, &num2, &pRM_TYPE);
        byte[] array = new byte[num2];
        try
        {
          byte[] array2 = array;
          fixed (byte* val2 = array2)
          {
            num = ximeaApi.xiGetParam((void*)handle, prm, val2, &num2, &pRM_TYPE);
            if (num == 0)
            {
              val = array;
              val_len = num2;
            }
            else
            {
              Array.Clear(val, 0, val.Length);
            }
          }
        }
        finally
        {
        }
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetParam " + prm);
      }
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    public byte[] GetParamByteArr(string prm)
    {
      int val_len = 0;
      byte[] val = null;
      GetParam(prm, out val, out val_len);
      return val;
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <param name="val">Byte array value to be returned.</param>
    public void GetParam(string prm, out string val)
    {
      int val_len = 0;
      val = string.Empty;
      GetParam(prm, out val, out val_len);
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <param name="val">String value to be returned.</param>
    /// <param name="val_len">Buffer lenght to be returned.</param>
    public unsafe void GetParam(string prm, out string val, out int val_len)
    {
      int num = 0;
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeString;
      int num2 = 1;
      val = string.Empty;
      val_len = 0;
      try
      {
        switch (pRM_TYPE)
        {
          case PRM_TYPE.TypeString:
            {
              num2 += 1046529;
              byte[] array = new byte[num2];
              try
              {
                byte[] array2 = array;
                fixed (byte* val2 = array2)
                {
                  num = ximeaApi.xiGetParam((void*)handle, prm, val2, &num2, &pRM_TYPE);
                  if (num == 0)
                  {
                    val = Encoding.ASCII.GetString(array, 0, num2);
                    val_len = num2;
                  }
                  else
                  {
                    val = "";
                  }
                }
              }
              finally
              {
              }
              break;
            }
          case PRM_TYPE.TypeFloat:
            {
              float num4 = 0f;
              num = ximeaApi.xiGetParam((void*)handle, prm, &num4, &num2, &pRM_TYPE);
              val = num4.ToString();
              val_len = num2;
              break;
            }
          case PRM_TYPE.TypeInteger:
          case PRM_TYPE.TypeBoolean:
          case PRM_TYPE.TypeCommand:
            {
              int num3 = 0;
              num = ximeaApi.xiGetParam((void*)handle, prm, &num3, &num2, &pRM_TYPE);
              val = num3.ToString();
              val_len = num2;
              break;
            }
          default:
            num = 103;
            break;
        }
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "GetParam " + prm);
      }
    }

    /// <summary>
    /// This function returns parameters information (current value, minimum, maximum, info).  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <returns>String value to be returned.</returns>
    public string GetParamString(string prm)
    {
      int val_len = 0;
      string val = string.Empty;
      GetParam(prm, out val, out val_len);
      return val;
    }
  }

}
