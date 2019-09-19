using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiApi
{
  /// <summary>
  /// Structure containing description of image areas and format.
  /// </summary>
  public struct XI_IMG_DESC
  {
    /// <summary>
    /// Pixels of Area0 of image left.
    /// </summary>
    public int Area0Left;

    /// <summary>
    /// Pixels of Area1 of image left.
    /// </summary>
    public int Area1Left;

    /// <summary>
    /// Pixels of Area2 of image left.
    /// </summary>
    public int Area2Left;

    /// <summary>
    /// Pixels of Area3 of image left.
    /// </summary>
    public int Area3Left;

    /// <summary>
    /// Pixels of Area4 of image left.
    /// </summary>
    public int Area4Left;

    /// <summary>
    /// Pixels of Area5 of image left.
    /// </summary>
    public int Area5Left;

    /// <summary>
    /// Width of active area.
    /// </summary>
    public int ActiveAreaWidth;

    /// <summary>
    /// Pixels of Area5 of image right.
    /// </summary>
    public int Area5Right;

    /// <summary>
    /// Pixels of Area4 of image right.
    /// </summary>
    public int Area4Right;

    /// <summary>
    /// Pixels of Area3 of image right.
    /// </summary>
    public int Area3Right;

    /// <summary>
    /// Pixels of Area2 of image right.
    /// </summary>
    public int Area2Right;

    /// <summary>
    /// Pixels of Area1 of image right.
    /// </summary>
    public int Area1Right;

    /// <summary>
    /// Pixels of Area0 of image right.
    /// </summary>
    public int Area0Right;

    /// <summary>
    /// Pixels of Area0 of image top.
    /// </summary>
    public int Area0Top;

    /// <summary>
    /// Pixels of Area1 of image top.
    /// </summary>
    public int Area1Top;

    /// <summary>
    /// Pixels of Area2 of image top.
    /// </summary>
    public int Area2Top;

    /// <summary>
    /// Pixels of Area3 of image top.
    /// </summary>
    public int Area3Top;

    /// <summary>
    /// Pixels of Area4 of image top.
    /// </summary>
    public int Area4Top;

    /// <summary>
    /// Pixels of Area5 of image top.
    /// </summary>
    public int Area5Top;

    /// <summary>
    /// Height of active area.
    /// </summary>
    public int ActiveAreaHeight;

    /// <summary>
    /// Pixels of Area5 of image bottom.
    /// </summary>
    public int Area5Bottom;

    /// <summary>
    /// Pixels of Area4 of image bottom.
    /// </summary>
    public int Area4Bottom;

    /// <summary>
    /// Pixels of Area3 of image bottom.
    /// </summary>
    public int Area3Bottom;

    /// <summary>
    /// Pixels of Area2 of image bottom.
    /// </summary>
    public int Area2Bottom;

    /// <summary>
    /// Pixels of Area1 of image bottom.
    /// </summary>
    public int Area1Bottom;

    /// <summary>
    /// Pixels of Area0 of image bottom.
    /// </summary>
    public int Area0Bottom;

    /// <summary>
    /// Current format of pixels. XI_GenTL_Image_Format_e.
    /// </summary>
    public int format;

    /// <summary>
    /// Description of areas and image.
    /// </summary>
    public int flags;
  }

}
