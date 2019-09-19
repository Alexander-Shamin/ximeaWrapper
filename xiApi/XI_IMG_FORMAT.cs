using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiApi
{
  /// <summary>
  /// Internal Ximea API enumerators for data formats.
  /// </summary>
  public enum XI_IMG_FORMAT
  {
    /// <summary>
    /// 8 bits per pixel.
    /// </summary>
    MONO8,
    /// <summary>
    /// 16 bits per pixel.
    /// </summary>
    MONO16,
    /// <summary>
    /// RGB  data format.
    /// </summary>
    RGB24,
    /// <summary>
    /// RGBA data format.
    /// </summary>
    RGB32,
    /// <summary>
    /// RGB planar data format.
    /// </summary>
    RGBPLANAR,
    /// <summary>
    /// 8 bits per pixel raw data from sensor.
    /// </summary>
    RAW8,
    /// <summary>
    /// 16 bits per pixel raw data from sensor.
    /// </summary>
    RAW16,
    /// <summary>
    /// Data from transport layer (e.g. packed).
    /// </summary>
    TRANSPORT_DATA
  }

}
