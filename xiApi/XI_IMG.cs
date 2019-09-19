using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiApi
{
  /// <summary>
  /// Structure containing information about incoming image.
  /// </summary>
  public struct XI_IMG
  {
    /// <summary>
    /// Size of structure.
    /// </summary>
    public int size;

    /// <summary>
    /// Pointer to data. If NULL, xiApi allocates new buffer.
    /// </summary>
    public unsafe void* bp;

    /// <summary>
    /// Buffer size.
    /// </summary>
    public int bp_size;

    /// <summary>
    /// Format of incoming data.	
    /// </summary>
    public XI_IMG_FORMAT frm;

    /// <summary>
    /// Width of incoming image.
    /// </summary>
    public int width;

    /// <summary>
    /// Height of incoming image.
    /// </summary>
    public int height;

    /// <summary>
    /// Frame number(reset by exposure, gain, downsampling change). 
    /// </summary>
    public int nframe;

    /// <summary>
    /// TimeStamp in seconds.
    /// </summary>
    public int tsSec;

    /// <summary>
    /// TimeStamp in microseconds.
    /// </summary>
    public int tsUSec;

    /// <summary>
    /// Input level.
    /// </summary>
    public int GPI_level;

    /// <summary>
    /// Black level of image (ONLY for MONO and RAW formats).
    /// </summary>
    public int black_level;

    /// <summary>
    /// Number of extra bytes provided at the end of each line to facilitate image alignment in buffers.
    /// </summary>
    public int padding_x;

    /// <summary>
    /// Horizontal offset of origin of sensor and buffer image first pixel.
    /// </summary>
    public int AbsoluteOffsetX;

    /// <summary>
    /// Vertical offset of origin of sensor and buffer image first pixel.
    /// </summary>
    public int AbsoluteOffsetY;

    /// <summary>
    /// Current format of pixels on transport layer. XI_GenTL_Image_Format_e.
    /// </summary>
    public int transport_frm;

    /// <summary>
    /// Description of image areas and format.
    /// </summary>
    private XI_IMG_DESC img_desc;

    /// <summary>
    /// Horizontal downsampling.
    /// </summary>
    public int DownsamplingX;

    /// <summary>
    /// Vertical downsampling.
    /// </summary>
    public int DownsamplingY;

    /// <summary>
    /// Description of XI_IMG.
    /// </summary>
    public int flags;

    /// <summary>
    /// Exposure time of this image in microseconds
    /// </summary>
    public int exposure_time_us;

    /// <summary>
    /// Gain used for this image in deci-bells.
    /// </summary>
    public float gain_db;

    /// <summary>
    /// Number of frames acquired from acquisition start.
    /// </summary>
    public int acq_nframe;

    /// <summary>
    /// ImageUserData controlled by user application using ImageUserData or XI_PRM_IMAGE_USER_DATA parameter.
    /// </summary>
    public int image_user_data;

    /// <summary>
    /// Array with five sub exposures times in microseconds used by XI_TRG_SEL_MULTIPLE_EXPOSURES or hardware controlled HDR.
    /// </summary>
    public unsafe fixed int exposure_sub_times_us[5];

    /// <summary>
    /// Initialize structure members.
    /// </summary>    
    public unsafe void Clear()
    {
      width = 1;
      height = 1;
      bp = null;
      frm = XI_IMG_FORMAT.MONO8;
      size = sizeof(XI_IMG);
      nframe = 0;
      tsSec = 0;
      tsUSec = 0;
      GPI_level = 0;
      black_level = 0;
      padding_x = 0;
      AbsoluteOffsetX = 0;
      AbsoluteOffsetY = 0;
    }
  }

}
