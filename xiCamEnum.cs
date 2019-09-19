using System;
using System.Text;
using xiApi;

namespace XimeaWrapper
{

  /// <summary>
  /// Contains function definitions for fast camera enumeration and identification.
  /// </summary>
  public class xiCamEnum
  {
    private int devCount;

    /// <summary>
    /// Class contructor, initializes class variables.
    /// </summary>
    public xiCamEnum()
    {
      devCount = ReEnumerate();
    }

    /// <summary>
    /// Class destructor, unitializes class variables.
    /// </summary>
    ~xiCamEnum()
    {
    }

    /// <summary>
    /// Re-enumerate available cameras. Returns the number of currently available devices.
    /// </summary>
    public unsafe int ReEnumerate()
    {
      fixed (int* numDevices = &devCount)
      {
        ximeaApi.xiGetNumberDevices(numDevices);
      }
      return devCount;
    }

    /// <summary>
    /// Retrieve serial number of device, in string format.
    /// </summary>
    /// <param name="devIndex">Index of device to be querried.</param>
    public string GetSerialNumById(int devIndex)
    {
      return GetDeviceInfo(devIndex, "device_sn");
    }

    /// <summary>
    /// Retrieve model name of device, in string format.
    /// </summary>
    /// <param name="devIndex">Index of device to be querried.</param>
    public string GetDevNameById(int devIndex)
    {
      return GetDeviceInfo(devIndex, "device_name");
    }

    /// <summary>
    /// Retrieve system instance path of device, in string format.
    /// </summary>
    /// <param name="devIndex">Index of device to be querried.</param>
    public string GetInstancePathById(int devIndex)
    {
      return GetDeviceInfo(devIndex, "device_inst_path");
    }

    /// <summary>
    /// Retrieve devicel location path, in string format.
    /// </summary>
    /// <param name="devIndex">Index of device to be querried.</param>
    public string GetLocationPathById(int devIndex)
    {
      return GetDeviceInfo(devIndex, "device_loc_path");
    }

    /// <summary>
    /// Retrieve type of device, in string format.
    /// </summary>
    /// <param name="devIndex">Index of device to be querried.</param>
    public string GetDeviceTypeById(int devIndex)
    {
      return GetDeviceInfo(devIndex, "device_type");
    }

    /// <summary>
    /// Retrieve type of device, in string format.
    /// </summary>
    /// <param name="devIndex">Index of device to be querried.</param>
    public string GetDeviceUserIdById(int devIndex)
    {
      return GetDeviceInfo(devIndex, "device_user_id");
    }

    /// <summary>
    /// Retrieve device info by ID, in string format.
    /// </summary>
    /// <param name="devIndex">Index of device to be querried.</param>
    /// /// <param name="param">Parameter to be returned.</param>
    private unsafe string GetDeviceInfo(int devIndex, string param)
    {
      int num = 512;
      string result = string.Empty;
      if (devIndex < 0 || devIndex > devCount)
      {
        ThrowException("Invalid device index, please re-enumerate cameras.");
      }
      byte[] array = new byte[num];
      Array.Clear(array, 0, num);
      byte[] array2 = array;
      fixed (byte* value = array2)
      {
        if (ximeaApi.xiGetDeviceInfoString(devIndex, param, value, num) == 0)
        {
          result = Encoding.Default.GetString(array);
          result = result.Remove(result.IndexOf("\0"));
        }
      }
      return result;
    }

    /// <summary>
    /// Send exception with detailed information to user.
    /// </summary>
    /// <param name="message">Detailed information for receiver.</param>
    private void ThrowException(string message)
    {
      ApplicationException ex = new ApplicationException(string.Format("Error : {1}", message));
      throw ex;
    }
  }

}
