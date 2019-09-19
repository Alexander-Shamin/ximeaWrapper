using System;
using System.Text;
using System.Runtime.InteropServices;
using xiApi;

namespace XimeaWrapper
{

  /// <summary>
  /// Contains function definitions for the offline processing xiAPI.NET class.
  /// </summary>
  public class xiProc
  {
    private const int XI_OK = 0;

    private UIntPtr handle;

    /// <summary>
    /// Class contructor, initializes class variables.
    /// </summary>
    public xiProc()
    {
      handle = UIntPtr.Zero;
    }

    /// <summary>
    /// Class destructor, unitializes class variables.
    /// </summary>
    ~xiProc()
    {
    }

    /// <summary>
    /// Opens new instance for Image Processing entity
    /// </summary>
    public unsafe void ProcOpen()
    {
      int num = 0;
      try
      {
        void* value = null;
        num = ximeaApi.xiProcOpen(&value);
        handle = new UIntPtr(value);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "xiProcOpen");
      }
    }

    /// <summary>
    /// Closes instance for Image Processing entity
    /// </summary>
    public unsafe void ProcClose()
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiProcClose((void*)handle);
      }
      catch
      {
        num = 0;
      }
      handle = UIntPtr.Zero;
      if (num != 0)
      {
        throw new xiExc(num, "xiProcOpen");
      }
    }

    /// <summary>
    /// Sets the selected parameter to processing
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to set parameters.</param>
    /// <param name="val">String value to be set.</param>
    public unsafe void ProcSetParam(string prm, string val)
    {
      int num = 0;
      if (val.Length == 0)
      {
        throw new xiExc(101, "ProcSetParam " + prm);
      }
      try
      {
        byte[] bytes = Encoding.ASCII.GetBytes(val);
        IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);
        num = ximeaApi.xiProcSetParam((void*)handle, prm, intPtr.ToPointer(), val.Length, PRM_TYPE.TypeString);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "ProcSetParam " + prm);
      }
    }

    /// <summary>
    /// Sets the selected parameter to processing
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to set parameters.</param>
    /// <param name="val">Integer value to be set.</param>
    public unsafe void ProcSetParamInt(string prm, int val)
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiProcSetParam((void*)handle, prm, &val, 4, PRM_TYPE.TypeInteger);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "ProcSetParamInt " + prm);
      }
    }

    /// <summary>
    /// Sets the selected parameter to processing
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to set parameters.</param>
    /// <param name="val">Float value to be set.</param>
    public unsafe void ProcSetParamFloat(string prm, int val)
    {
      int num = 0;
      try
      {
        num = ximeaApi.xiProcSetParam((void*)handle, prm, &val, 4, PRM_TYPE.TypeFloat);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "ProcSetParamFloat " + prm);
      }
    }

    /// <summary>
    /// Gets the selected parameter from processing.  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <returns>String value to be returned.</returns>
    public unsafe string ProcGetParam(string prm)
    {
      int num = 0;
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeString;
      int num2 = 1;
      string result = string.Empty;
      try
      {
        ximeaApi.xiProcGetParam((void*)handle, prm, null, &num2, &pRM_TYPE);
        switch (pRM_TYPE)
        {
          case PRM_TYPE.TypeString:
            {
              num2 += 10;
              byte[] array = new byte[num2];
              try
              {
                byte[] array2 = array;
                fixed (byte* val = array2)
                {
                  num = ximeaApi.xiProcGetParam((void*)handle, prm, val, &num2, &pRM_TYPE);
                  result = ((num != 0) ? "" : Encoding.ASCII.GetString(array, 0, num2));
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
              num = ximeaApi.xiProcGetParam((void*)handle, prm, &num4, &num2, &pRM_TYPE);
              result = num4.ToString();
              break;
            }
          case PRM_TYPE.TypeInteger:
          case PRM_TYPE.TypeBoolean:
          case PRM_TYPE.TypeCommand:
            {
              int num3 = 0;
              num = ximeaApi.xiProcGetParam((void*)handle, prm, &num3, &num2, &pRM_TYPE);
              result = num3.ToString();
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
        throw new xiExc(num, "xiProcGetParam " + prm);
      }
      return result;
    }

    /// <summary>
    /// Gets the selected parameter from processing.  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <returns>Integer value to be returned.</returns>
    public unsafe int ProcGetParamInt(string prm)
    {
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeInteger;
      int num = 0;
      int num2 = 4;
      int result = 0;
      try
      {
        num = ximeaApi.xiProcGetParam((void*)handle, prm, &result, &num2, &pRM_TYPE);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "xiProcGetParamInt " + prm);
      }
      return result;
    }

    /// <summary>
    /// Gets the selected parameter from processing.  
    /// </summary>
    /// <param name="prm">Parameter name string. Use class PRM to get parameters.</param>
    /// <returns>Integer value to be returned.</returns>
    public unsafe float ProcGetParamFloat(string prm)
    {
      int num = 0;
      PRM_TYPE pRM_TYPE = PRM_TYPE.TypeFloat;
      int num2 = 4;
      float result = 0f;
      try
      {
        num = ximeaApi.xiProcGetParam((void*)handle, prm, &result, &num2, &pRM_TYPE);
      }
      catch
      {
        num = 1;
      }
      if (num != 0)
      {
        throw new xiExc(num, "xiProcGetParamFloat " + prm);
      }
      return result;
    }

    /// <summary>
    /// Set unprocessed image to processing chain, only pointer to data in XI_IMG will be used.  
    /// </summary>        
    /// <param name="image">Byte array of pixels of image to be processed.</param>
    public unsafe void ProcPushImage(XI_IMG image)
    {
      int num = 0;
      num = ximeaApi.xiProcPushImage((void*)handle, image.bp);
      if (num != 0)
      {
        throw new xiExc(num, "xiProcPushImage ");
      }
    }

    /// <summary>
    /// Set unprocessed image to processing chain, XI_IMG members will be used in processing chain.  
    /// </summary>        
    /// <param name="image">XI_IMG structure with image data.</param>
    public unsafe void ProcPushXiImg(XI_IMG image)
    {
      int num = 0;
      num = ximeaApi.xiProcPushXiImg((void*)handle, &image);
      if (num != 0)
      {
        throw new xiExc(num, "xiProcPushXiImg ");
      }
    }

    /// <summary>
    /// Internal handler of xiProcPullImage for all instances in class.
    /// </summary>        
    /// <param name="img">XI_IMG struct to be filled.</param>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    internal unsafe void ProcPullImageInternal(out XI_IMG img, int timeout)
    {
      int num = 0;
      XI_IMG xI_IMG = default(XI_IMG);
      xI_IMG.Clear();
      num = ximeaApi.xiProcPullImage((void*)handle, timeout, &xI_IMG);
      if (num != 0)
      {
        throw new xiExc(num, "xiProcPushImage ");
      }
      img = xI_IMG;
    }

    ///// <summary>
    ///// Gets processed image from processing chain.  
    ///// </summary>        
    ///// <param name="image">Bitmap image to be returned.</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void ProcPullImage(out Bitmap image, int timeout)
    //{
    //  XI_IMG img = default(XI_IMG);
    //  img.Clear();
    //  ProcPullImageInternal(out img, timeout);
    //  xiImg xiImg = new xiImg(img);
    //  xiImg.GetBitmapByRef(out image);
    //}

    ///// <summary>
    ///// Gets processed image from processing chain.  
    ///// </summary>        
    ///// <param name="image">BitmapSource image to be returned.</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void ProcPullImage(out BitmapSource image, int timeout)
    //{
    //  XI_IMG img = default(XI_IMG);
    //  img.Clear();
    //  ProcPullImageInternal(out img, timeout);
    //  xiImg xiImg = new xiImg(img);
    //  xiImg.GetBitmapSourceByRef(out image);
    //}

    ///// <summary>
    ///// Gets processed image from processing chain.  
    ///// </summary>        
    ///// <param name="val">WriteableBitmap image to be returned.</param>
    ///// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    //public void ProcPullImage(out WriteableBitmap image, int timeout)
    //{
    //  XI_IMG img = default(XI_IMG);
    //  img.Clear();
    //  ProcPullImageInternal(out img, timeout);
    //  xiImg xiImg = new xiImg(img);
    //  xiImg.GetWriteableBitmapByRef(out image);
    //}

    /// <summary>
    /// Gets processed image from processing chain.  
    /// </summary>        
    /// <param name="img_arr">Byte array image data to be returned.</param>
    /// <param name="timeout">Time interval required to wait for the image (in milliseconds)</param>
    public void ProcPullImage(out byte[] img_arr, int timeout)
    {
      XI_IMG img = default(XI_IMG);
      img.Clear();
      ProcPullImageInternal(out img, timeout);
      xiImg xiImg = new xiImg(img);
      xiImg.GetByteArrayByRef(out img_arr);
    }
  }

}
