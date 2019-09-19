using System;

namespace XimeaWrapper
{
  /// <summary>
  /// Internal exception handler for xiAPI.NET.
  /// </summary>
  internal class xiExc : ApplicationException
  {
    private string internal_message;

    /// <summary>
    /// Overriding the message element.
    /// </summary>
    public override string Message => internal_message;

    /// <summary>
    /// Constructor to pass error code and parameter string.
    /// </summary>
    public xiExc(int err_code, string param)
    {
      base.HResult = err_code;
      internal_message = ComposeMessage(err_code, param);
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    public xiExc(xiExc exc)
    {
      base.HResult = exc.HResult;
      internal_message = exc.Message;
    }

    /// <summary>
    /// Compose error message from error code and parameter.
    /// </summary>
    /// <param name="errNum">Error code from xiAPI</param>
    /// <param name="param">Parameter description where exception occurred</param>
    private static string ComposeMessage(int errNum, string param)
    {
      if (errNum == 0)
      {
        return string.Empty;
      }
      string empty = string.Empty;
      switch (errNum)
      {
        case 1:
          return param + ": Invalid handle";
        case 2:
          return param + ": Register read error";
        case 3:
          return param + ": Register write error";
        case 4:
          return param + ": Freeing resources error";
        case 5:
          return param + ": Freeing channel error";
        case 6:
          return param + ": Freeing bandwith error";
        case 7:
          return param + ": Read block error";
        case 8:
          return param + ": Write block error";
        case 9:
          return param + ": No image";
        case 10:
          return param + ": Timeout";
        case 11:
          return param + ": Invalid arguments supplied";
        case 12:
          return param + ": Not supported";
        case 13:
          return param + ": Attach buffers error";
        case 14:
          return param + ": Overlapped result";
        case 15:
          return param + ": Memory allocation error";
        case 16:
          return param + ": DLL context is NULL";
        case 17:
          return param + ": DLL context is non zero";
        case 18:
          return param + ": DLL context exists";
        case 19:
          return param + ": Too many devices connected";
        case 20:
          return param + ": Camera context error";
        case 21:
          return param + ": Unknown hardware";
        case 22:
          return param + ": Invalid TM file";
        case 23:
          return param + ": Invalid TM tag";
        case 24:
          return param + ": Incomplete TM";
        case 25:
          return param + ": Bus reset error";
        case 26:
          return param + ": Not implemented";
        case 27:
          return param + ": Shading is too bright";
        case 28:
          return param + ": Shading is too dark";
        case 29:
          return param + ": Gain is too low";
        case 30:
          return param + ": Invalid bad pixel list";
        case 31:
          return param + ": Bad pixel list realloc error";
        case 32:
          return param + ": Invalid pixel list";
        case 33:
          return param + ": Invalid Flash File System";
        case 34:
          return param + ": Invalid profile";
        case 35:
          return param + ": Invalid calibration";
        case 36:
          return param + ": Invalid buffer";
        case 38:
          return param + ": Invalid data";
        case 39:
          return param + ": Timing generator is busy";
        case 40:
          return param + ": Wrong operation open/write/read/close";
        case 41:
          return param + ": Acquisition already started";
        case 42:
          return param + ": Old version of device driver installed to the system.";
        case 43:
          return param + ": To get error code please call GetLastError function.";
        case 44:
          return param + ": Data cannot be processed";
        case 45:
          return param + ": Acquisition is stopped. It needs to be started to perform operation.";
        case 46:
          return param + ": Acquisition has been stopped with an error.";
        case 47:
          return param + ": Input ICC profile missing or corrupted";
        case 48:
          return param + ": Output ICC profile missing or corrupted";
        case 49:
          return param + ": Device not ready to operate";
        case 50:
          return param + ": Shading is too contrast";
        case 51:
          return param + ": Module already initialized";
        case 52:
          return param + ": Application does not have enough privileges (one or more app)";
        case 53:
          return param + ": Installed driver is not compatible with current software";
        case 54:
          return param + ": TM file was not loaded successfully from resources";
        case 55:
          return param + ": Device has been reset, abnormal initial state";
        case 56:
          return param + ": No Devices Found";
        case 57:
          return param + ": Resource (device) or function locked by mutex";
        case 58:
          return param + ": Buffer provided by user is too small";
        case 59:
          return param + ": Couldn't initialize processor.";
        case 60:
          return param + ": The object/module/procedure/process being referred to has not been started.";
        case 61:
          return param + ": Resource not found (could be processor, file, item...).";
        case 100:
          return param + ": Unknown parameter";
        case 101:
          return param + ": Wrong parameter value";
        case 103:
          return param + ": Wrong parameter type";
        case 104:
          return param + ": Wrong parameter size";
        case 105:
          return param + ": Input buffer is too small";
        case 106:
          return param + ": Parameter is not supported";
        case 107:
          return param + ": Parameter info not supported";
        case 108:
          return param + ": Data format is not supported";
        case 109:
          return param + ": Read only parameter";
        case 111:
          return param + ": This camera does not support currently available bandwidth";
        case 112:
          return param + ": FFS file selector is invalid or NULL";
        case 113:
          return param + ": FFS file not found.";
        case 114:
          return param + ": Parameter value cannot be set (might be out of range or invalid).";
        case 201:
          return param + ": Processing error - other";
        case 202:
          return param + ": Error while image processing.";
        case 203:
          return param + ": Input format is not supported for processing.";
        case 204:
          return param + ": Output format is not supported for processing.";
        default:
          return param + ": xiAPI.NET error.";
      }
    }
  }

}
