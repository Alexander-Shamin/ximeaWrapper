using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using xiApi;

namespace XimeaWrapper
{

  /// <summary>
  /// Wrap XI_IMG structure into various .NET image formats
  /// </summary>
  internal class xiImg
  {
    /// <summary>
    /// Internal XI_IMG instance to be used for image creation.
    /// </summary>
    private XI_IMG img;

    /// <summary>
    /// xiImg constructor with internal initializations.
    /// </summary>
    public xiImg()
    {
      img.Clear();
    }

    /// <summary>
    /// xiImg constructor passing XI_IMG structure.
    /// </summary>
    /// <param name="image_struc">XI_IMG structure to be used for image geneartion.</param>
    public xiImg(XI_IMG image_struc)
    {
      img.Clear();
      img = image_struc;
    }

    /// <summary>
    /// Update internal XI_IMG structure for image creation.
    /// </summary>
    /// <param name="image_struc">XI_IMG structure to be used for image geneartion.</param>
    public void SetImageData(XI_IMG image_struct)
    {
      img = image_struct;
    }

    ///// <summary>
    ///// Returns BitmapSource filled with data.
    ///// </summary>
    ///// <param name="image">Reference to BitmapSource image.</param>
    //public unsafe void GetBitmapSourceByRef(out BitmapSource image)
    //{
    //  IntPtr buffer = new IntPtr(img.bp);
    //  System.Windows.Media.PixelFormat pixelFormat = default(System.Windows.Media.PixelFormat);
    //  int num = 0;
    //  int num2 = 0;
    //  switch (img.frm)
    //  {
    //    case XI_IMG_FORMAT.MONO8:
    //    case XI_IMG_FORMAT.RAW8:
    //      pixelFormat = PixelFormats.Gray8;
    //      num = img.width + img.padding_x;
    //      num2 = 1;
    //      break;
    //    case XI_IMG_FORMAT.MONO16:
    //    case XI_IMG_FORMAT.RAW16:
    //      pixelFormat = PixelFormats.Gray16;
    //      num = (img.width + img.padding_x / 2) * 2;
    //      num2 = 2;
    //      break;
    //    case XI_IMG_FORMAT.RGB24:
    //    case XI_IMG_FORMAT.RGBPLANAR:
    //      pixelFormat = PixelFormats.Bgr24;
    //      num = (img.width + img.padding_x / 3) * 3;
    //      num2 = 3;
    //      break;
    //    case XI_IMG_FORMAT.RGB32:
    //      pixelFormat = PixelFormats.Bgr32;
    //      num = (img.width + img.padding_x / 4) * 4;
    //      num2 = 4;
    //      break;
    //    default:
    //      throw new xiExc(108, "GetImage");
    //  }
    //  List<System.Windows.Media.Color> list = new List<System.Windows.Media.Color>();
    //  list.Add(Colors.Red);
    //  list.Add(Colors.Blue);
    //  list.Add(Colors.Green);
    //  BitmapPalette palette = new BitmapPalette(list);
    //  image = BitmapSource.Create(img.width + img.padding_x / num2, img.height, 96.0, 96.0, pixelFormat, palette, buffer, num * img.height, num);
    //}

    ///// <summary>
    ///// Returns WriteableBitmap filled with data.
    ///// </summary>
    ///// <param name="image">Reference to WriteableBitmap image.</param>
    //public void GetWriteableBitmapByRef(out WriteableBitmap image)
    //{
    //  GetBitmapSourceByRef(out BitmapSource image2);
    //  image = new WriteableBitmap(image2);
    //}

    ///// <summary>
    ///// Returns Bitmap filled with data.
    ///// </summary>
    ///// <param name="image">Reference to Bitmap image.</param>
    //public unsafe void GetBitmapByRef(out Bitmap image)
    //{
    //  IntPtr scan = new IntPtr(img.bp);
    //  System.Drawing.Imaging.PixelFormat pixelFormat = System.Drawing.Imaging.PixelFormat.Undefined;
    //  int num = 0;
    //  int num2 = 0;
    //  switch (img.frm)
    //  {
    //    case XI_IMG_FORMAT.MONO8:
    //    case XI_IMG_FORMAT.RAW8:
    //      pixelFormat = System.Drawing.Imaging.PixelFormat.Format8bppIndexed;
    //      num = img.width + img.padding_x;
    //      num2 = 1;
    //      break;
    //    case XI_IMG_FORMAT.MONO16:
    //    case XI_IMG_FORMAT.RAW16:
    //      pixelFormat = System.Drawing.Imaging.PixelFormat.Format16bppGrayScale;
    //      num = (img.width + img.padding_x / 2) * 2;
    //      num2 = 2;
    //      break;
    //    case XI_IMG_FORMAT.RGB24:
    //    case XI_IMG_FORMAT.RGBPLANAR:
    //      pixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb;
    //      num = (img.width + img.padding_x / 3) * 3;
    //      num2 = 3;
    //      break;
    //    case XI_IMG_FORMAT.RGB32:
    //      pixelFormat = System.Drawing.Imaging.PixelFormat.Format32bppRgb;
    //      num = (img.width + img.padding_x / 4) * 4;
    //      num2 = 4;
    //      break;
    //    default:
    //      throw new xiExc(108, "GetImage");
    //  }
    //  image = new Bitmap(img.width + img.padding_x / num2, img.height, num, pixelFormat, scan);
    //  if (pixelFormat == System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
    //  {
    //    ColorPalette palette = image.Palette;
    //    for (int i = 0; i <= 255; i++)
    //    {
    //      palette.Entries[i] = System.Drawing.Color.FromArgb(i, i, i);
    //    }
    //    image.Palette = palette;
    //  }
    //}

    /// <summary>
    /// Returns byte array filled with data.
    /// </summary>
    /// <param name="image">Reference to byte array.</param>
    public unsafe void GetByteArrayByRef(out byte[] img_arr)
    {
      int num = 0;
      switch (img.frm)
      {
        case XI_IMG_FORMAT.MONO8:
        case XI_IMG_FORMAT.RAW8:
          num = (img.width + img.padding_x) * img.height;
          break;
        case XI_IMG_FORMAT.MONO16:
        case XI_IMG_FORMAT.RAW16:
          num = (img.width + img.padding_x / 2) * 2 * img.height;
          break;
        case XI_IMG_FORMAT.RGB24:
        case XI_IMG_FORMAT.RGBPLANAR:
          num = (img.width + img.padding_x / 3) * 3 * img.height;
          break;
        case XI_IMG_FORMAT.RGB32:
          num = (img.width + img.padding_x / 4) * 4 * img.height;
          break;
        default:
          throw new xiExc(108, "GetImage");
      }
      img_arr = new byte[num];
      IntPtr source = new IntPtr(img.bp);
      Marshal.Copy(source, img_arr, 0, num);
    }
  }

}
