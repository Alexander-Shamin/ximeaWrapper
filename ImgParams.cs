using System;
using xiApi;

namespace XimeaWrapper
{

  /// <summary>
  /// Provide additional information about the acquired image.
  /// </summary>
  public class ImgParams
  {
    /// <summary>
    /// Storing informations about the last image.
    /// </summary>
    private XI_IMG image_params;

    /// <summary>
    /// Returns data format of the last acquired image.
    /// </summary>
    public int GetDataFormat()
    {
      return Convert.ToInt32(image_params.frm);
    }

    /// <summary>
    /// Returns width of the last acquired image.
    /// </summary>
    public int GetWidth()
    {
      return image_params.width;
    }

    /// <summary>
    /// Returns height of the last acquired image.
    /// </summary>
    public int GetHeight()
    {
      return image_params.height;
    }

    /// <summary>
    /// Returns number of the last acquired image.
    /// </summary>
    public int GetFrameNum()
    {
      return image_params.nframe;
    }

    /// <summary>
    /// Returns time stamp in seconds with microsecond precision.
    /// </summary>
    public double GetTimestamp()
    {
      return (double)image_params.tsSec + (double)image_params.tsUSec / 1000000.0;
    }

    /// <summary>
    /// Returns GPI input level.
    /// </summary>
    public int GetDigitalInputLevel()
    {
      return image_params.GPI_level;
    }

    /// <summary>
    /// Returns image black level (only for RAW and Mono formats).
    /// </summary>
    public int GetBlackLevel()
    {
      return image_params.black_level;
    }

    /// <summary>
    /// Returns image black level (only for RAW and Mono formats).
    /// </summary>
    public int GetPaddingX()
    {
      return image_params.padding_x;
    }

    /// <summary>
    /// Returns image black level (only for RAW and Mono formats).
    /// </summary>
    public int GetAbsoluteOffsetX()
    {
      return image_params.AbsoluteOffsetX;
    }

    /// <summary>
    /// Returns image black level (only for RAW and Mono formats).
    /// </summary>
    public int GetAbsoluteOffsetY()
    {
      return image_params.AbsoluteOffsetY;
    }

    /// <summary>
    /// Returns XI_IMG structure .
    /// </summary>
    public XI_IMG GetLastImageStruct()
    {
      return image_params;
    }

    /// <summary>
    /// Constructor to initialize internal structure.
    /// </summary>
    public ImgParams()
    {
      image_params = default(XI_IMG);
      image_params.Clear();
    }

    /// <summary>
    /// Update internal data.
    /// </summary>
    internal void UpdateValues(XI_IMG update_struc)
    {
      image_params = update_struc;
    }
  }

}
