using System;

namespace XimeaWrapper
{
  /// <summary>
  /// Definitions containing information about acqisition timing modes.
  /// </summary>
  public static class ACQ_TIMING_MODE
  {
    /// <summary> Selects a mode when sensor timing is given by fastest framerate possible (by exposure time and readout)</summary>
    public const int FREE_RUN = 0;

    /// <summary> Selects a mode when sensor frame acquisition frequency is set to FRAMERATE</summary>
    public const int FRAME_RATE = 1;

    /// <summary> Selects a mode when sensor frame acquisition frequency is limited by FRAMERATE</summary>
    public const int FRAME_RATE_LIMIT = 2;
  }

  /// <summary>
  /// Acquisition status Selector
  /// </summary>
  public static class ACQUISITION_STATUS_SELECTOR
  {
    /// <summary> Device is currently doing an acquisition</summary>
    public const int ACQUISITION_STATUS_ACQ_ACTIVE = 0;
  }

  /// <summary>
  /// Selects binning mode 
  /// </summary>
  public static class BINNING_MODE
  {
    /// <summary>
    /// The response from the combined pixels will be added, resulting in increased sensitivity.
    /// </summary>
    public const int SUM = 0;

    /// <summary>
    /// The response from the combined pixels will be averaged, resulting in increased signal/noise ratio.
    /// </summary>
    public const int AVERAGE = 1;
  }

  // xiApi.NET.BINNING_PATTERN
  /// <summary>
  /// Selects Binning pattern type.
  /// </summary>
  public static class BINNING_PATTERN
  {
    /// <summary>
    /// Monochrome type binning - adjacent pixels are combined.
    /// </summary>
    public const int MONO = 1;

    /// <summary>
    /// Bayer type binning - bayer pattern is preserved during pixel combining.
    /// </summary>
    public const int BAYER = 2;
  }

  // xiApi.NET.BINNING_SELECTOR
  /// <summary>
  /// Selects which binning engine is configured by BinningHorizontal, BinningVertical and BinningPattern parameters
  /// </summary>
  public static class BINNING_SELECTOR
  {
    /// <summary>
    /// Sensor binning engine selected (if available)
    /// </summary>
    public const int SENSOR = 0;
  }

  // xiApi.NET.BUFF_POLICY
  /// <summary>
  /// Buffer policy settings(can be safe, data will be copied to user/app buffer or unsafe, user will get internally allocated buffer without data copy).
  /// </summary>
  public static class BUFF_POLICY
  {
    /// <summary>
    /// User gets pointer to internally allocated circle buffer and data may be overwritten by device.
    /// </summary>
    public const int UNSAFE = 0;

    /// <summary>
    /// Data from device will be copied to user allocated buffer or xiApi allocated memory.
    /// </summary>
    public const int SAFE = 1;
  }

  // xiApi.NET.CMS_INTENTS
  /// <summary>
  /// CMS functionality options
  /// </summary>
  public static class CMS_INTENTS
  {
    /// <summary> intent perceptual.</summary>
    public const int INTENT_PERCEPTUAL = 0;

    /// <summary> intent relative colorimetric.</summary>
    public const int RELATIVE_COLORIMETRIC = 1;

    /// <summary> intent saturation.</summary>
    public const int SATURATION = 2;

    /// <summary> intent absolute colorimetric.</summary>
    public const int ABSOLUTE_COLORIMETRIC = 3;
  }

  // xiApi.NET.CMS_MODE
  /// <summary>
  /// CMS functionality options
  /// </summary>
  public static class CMS_MODE
  {
    /// <summary> CMS disable.</summary>
    public const int DIS = 0;

    /// <summary> CMS enable.</summary>
    public const int EN = 1;

    /// <summary> CMS enable(fast).</summary>
    public const int EN_FAST = 2;
  }

  // xiApi.NET.COUNTER_SELECTOR
  /// <summary>
  /// Definitions containing information about frames counter selector.
  /// </summary>
  public static class COUNTER_SELECTOR
  {
    /// <summary> Number of skipped frames on transport layer (e.g. when image gets lost while transmission). Occur when capacity of transport channel does not allow to transfer all data.</summary>
    public const int CNT_SEL_TRANSPORT_SKIPPED_FRAMES = 0;

    /// <summary> Number of skipped frames on API layer. Occur when application does not process the images as quick as they are received from the camera.</summary>
    public const int CNT_SEL_API_SKIPPED_FRAMES = 1;

    /// <summary> Number of successfully transferred frames on transport layer.</summary>
    public const int CNT_SEL_TRANSPORT_TRANSFERRED_FRAMES = 2;
  }

  // xiApi.NET.DEBUG_LEVEL
  /// <summary>
  /// Debug level enumerator.
  /// </summary>
  public static class DEBUG_LEVEL
  {
    /// <summary> Information level.</summary>
    public const int TRACE = 0;

    /// <summary> Warning level.</summary>
    public const int WARNING = 1;

    /// <summary> Error level.</summary>
    public const int ERROR = 2;

    /// <summary> Fatal error level.</summary>
    public const int FATAL = 3;
  }

  // xiApi.NET.DECIMATION_PATTERN
  /// <summary>
  /// Selects Decimation pattern type.
  /// </summary>
  public static class DECIMATION_PATTERN
  {
    /// <summary>
    /// Monochrome type decimation - adjacent pixels are skipped.
    /// </summary>
    public const int MONO = 1;

    /// <summary>
    /// Bayer type decimation - bayer pattern is preserved during pixel skipping.
    /// </summary>
    public const int BAYER = 2;
  }

  // xiApi.NET.DECIMATION_SELECTOR
  /// <summary>
  /// Selects which decimation engine is configured by DecimationHorizontal, DecimationVertical and DecimationPattern parameters
  /// </summary>
  public static class DECIMATION_SELECTOR
  {
    /// <summary>
    /// Sensor decimation engine selected (if available)
    /// </summary>
    public const int SENSOR = 0;
  }

  // xiApi.NET.DOWNSAMPLING_TYPE
  /// <summary>
  /// Downsampling type, switch between binning and skipping, to be used with the PRM.DOWNSAMPLING_TYPE function parameter.
  /// </summary>
  public static class DOWNSAMPLING_TYPE
  {
    /// <summary>
    /// Binned type for higher sensitivity.
    /// </summary>
    public const int BINNING = 0;

    /// <summary>
    /// Skipped type for higher framerates.
    /// </summary>
    public const int SKIPPING = 1;
  }

  // xiApi.NET.GAIN_SELECTOR_TYPE
  /// <summary>
  /// Selects gain to be set with Gain parameters. 
  /// </summary>
  public static class GAIN_SELECTOR_TYPE
  {
    /// <summary>
    /// Gain selector selects all channels. Implementation of gain type depends on camera.
    /// </summary>
    public const int GAIN_SELECTOR_ALL = 0;

    /// <summary>
    /// Gain selector selects all analog channels. This is available only on some cameras.
    /// </summary>
    public const int GAIN_SELECTOR_ANALOG_ALL = 1;

    /// <summary>
    /// Gain selector selects all digital channels. This is available only on some cameras.
    /// </summary>
    public const int GAIN_SELECTOR_DIGITAL_ALL = 2;
  }

  // xiApi.NET.GPI_MODE
  /// <summary>
  /// GPI port state options
  /// </summary>
  public static class GPI_MODE
  {
    /// <summary> Input off.</summary>
    public const int OFF = 0;

    /// <summary> Trigger input.</summary>
    public const int TRIGGER = 1;

    /// <summary> External signal input. It is not implemented yet.</summary>
    public const int EXT_EVENT = 2;
  }

  // xiApi.NET.GPO_MODE
  /// <summary>
  /// GPO port state options
  /// </summary>
  public static class GPO_MODE
  {
    /// <summary> Output off.</summary>
    public const int OFF = 0;

    /// <summary> Logical level.</summary>
    public const int ON = 1;

    /// <summary> High during exposure(integration) time + readout time + data transfer time.</summary>
    public const int FRAME_ACTIVE = 2;

    /// <summary> Low during exposure(integration) time + readout time + data trasnfer time.</summary>
    public const int FRAME_ACTIVE_NEG = 3;

    /// <summary> High during exposure(integration) time.</summary>
    public const int EXPOSURE_ACTIVE = 4;

    /// <summary> Low during exposure(integration) time.</summary>
    public const int EXPOSURE_ACTIVE_NEG = 5;

    /// <summary> On when sensor is ready for next trigger edge. </summary>
    public const int FRAME_TRIGGER_READY = 6;

    /// <summary> Off when sensor is ready for next trigger edge. </summary>
    public const int FRAME_TRIGGER_READY_NEG = 7;

    /// <summary> Short On/Off pulse on start of each exposure. </summary>
    public const int EXPOSURE_PULSE = 8;

    /// <summary> Short Off/On pulse on start of each exposure. </summary>
    public const int EXPOSURE_PULSE_NEG = 9;
  }

  // xiApi.NET.IMG_COLOR_FILTER_ARRAY
  /// <summary>
  /// Output image color filter array of RAW images.
  /// </summary>
  public static class IMG_COLOR_FILTER_ARRAY
  {
    /// <summary>
    /// B/W sensors.
    /// </summary>
    public const int NONE = 0;

    /// <summary>
    /// Regular Bayer RGGB readout
    /// </summary>
    public const int BAYER_RGGB = 1;

    /// <summary>
    ///             AK Sony sensors
    /// </summary>
    public const int CMYG = 2;

    /// <summary>
    /// 2R+G readout of RGGB sensor
    /// </summary>
    public const int RGR = 3;

    /// <summary>
    /// Bayer BGGR readout
    /// </summary>
    public const int BAYER_BGGR = 4;

    /// <summary>
    /// Bayer GRBG readout
    /// </summary>
    public const int BAYER_GRBG = 5;

    /// <summary>
    /// Bayer GBRG readout
    /// </summary>
    public const int BAYER_GBRG = 6;
  }

  // xiApi.NET.IMG_FORMAT
  /// <summary>
  /// Output image format definitions to be used with the PRM.IMAGE_DATA_FORMAT function parameter.
  /// </summary>
  public static class IMG_FORMAT
  {
    /// <summary>
    /// Monochrome image with 8 bits per pixel.
    /// </summary>
    public const int MONO8 = 0;

    /// <summary>
    /// Monochrome image with 16 bits per pixel.
    /// </summary>
    public const int MONO16 = 1;

    /// <summary>
    ///             RGB  image data format image with 8 bits per pixel.
    /// </summary>
    public const int RGB24 = 2;

    /// <summary>
    /// RGBA image data format image with 8 bits per pixel, Alpha values not valid.
    /// </summary>
    public const int RGB32 = 3;

    /// <summary>
    /// RGB planar image data format image with 8 bits per pixel.
    /// </summary>
    public const int RGBPLANAR = 4;

    /// <summary>
    /// 8 bits per pixel raw data from sensor.
    /// </summary>
    public const int RAW8 = 5;

    /// <summary>
    /// 16 bits per pixel raw data from sensor.
    /// </summary>
    public const int RAW16 = 6;
  }

  // xiApi.NET.LED_MODE
  /// <summary>
  /// Camera LED state options
  /// </summary>
  public static class LED_MODE
  {
    /// <summary> Blink if link is ok (led 1), heartbeat mode (led 2).</summary>
    public const int LED_HEARTBEAT = 0;

    /// <summary> Blink led if trigger detected.</summary>
    public const int LED_TRIGGER_ACTIVE = 1;

    /// <summary> Blink led if external signal detected.</summary>
    public const int LED_EXT_EVENT_ACTIVE = 2;

    /// <summary> Blink led during data streaming.</summary>
    public const int LED_ACQUISITION = 3;

    /// <summary> Blink led during sensor integration time.</summary>
    public const int LED_EXPOSURE_ACTIVE = 4;

    /// <summary> Blink if device busy/not busy.</summary>
    public const int LED_FRAME_ACTIVE = 5;

    /// <summary> Blink led if link is ok.</summary>
    public const int LED_LINK = 6;

    /// <summary> Set led to zero.</summary>
    public const int LED_OFF = 7;

    /// <summary> Set led to one.</summary>
    public const int LED_ON = 8;
  }

  // xiApi.NET.LENS_FEATURE_SELECTOR
  /// <summary>
  /// Possible values for lens feature selector
  /// </summary>
  public static class LENS_FEATURE_SELECTOR
  {
    /// <summary>Status of lens motorized focus switch.</summary>
    public const int MOTORIZED_FOCUS_SWITCH = 1;

    /// <summary>On read = 1 if motorized focus is on one of limits.</summary>
    public const int MOTORIZED_FOCUS_BOUNDED = 2;

    /// <summary>On read = 1 if motorized focus is calibrated. Write 1 to start calibration.</summary>
    public const int MOTORIZED_FOCUS_CALIBRATION = 3;

    /// <summary>On read = 1 if image stabilization is enabled. Write 1 to enable image stabilization.</summary>
    public const int IMAGE_STABILIZATION_ENABLED = 4;

    /// <summary>On read = 1 if image stabilization switch is in position On.</summary>
    public const int IMAGE_STABILIZATION_SWITCH_STATUS = 5;

    /// <summary>On read = 1 if lens supports zoom = are not prime.</summary>
    public const int IMAGE_ZOOM_SUPPORTED = 6;
  }

  // xiApi.NET.LENS_MODE
  /// <summary>
  /// Possible values for lens mode
  /// </summary>
  public static class LENS_MODE
  {
    /// <summary>Status of lens control when not initialized.</summary>
    public const int OFF = 0;

    /// <summary>Status of lens after being initialized and ready.</summary>
    public const int ON = 1;
  }

  // xiApi.NET.OUTPUT_DATA_PACKING_TYPE
  /// <summary>
  /// Data packing(grouping) types.
  /// </summary>
  public static class OUTPUT_DATA_PACKING_TYPE
  {
    /// <summary>Data grouping (10g160, 12g192, 14g224).</summary>
    public const int XI_GROUPING = 0;

    /// <summary>Data packing (10p, 12p).</summary>
    public const int PFNC_LSB_PACKING = 1;
  }

  // xiApi.NET.PRM
  /// <summary>
  /// Parameters available for set/get operations.
  /// </summary>
  public static class PRM
  {
    /// <summary>
    /// Get camera model name. Type string.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_NAME, out string val);
    /// </remarks>
    public const string DEVICE_NAME = "device_name";

    /// <summary>
    /// Returns device type (1394, USB2.0, CURRERA…..). Type string.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_TYPE, out string val)
    /// </remarks>
    public const string DEVICE_TYPE = "device_type";

    /// <summary>
    /// Returns device model id . Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_MODEL_ID, out int val)
    /// </remarks>
    public const string DEVICE_MODEL_ID = "device_model_id";

    /// <summary>
    /// Returns device sensor model id . Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_MODEL_ID, out int val)
    /// </remarks>
    public const string SENSOR_MODEL_ID = "sensor_model_id";

    /// <summary>
    /// Set the amount of debug prints to be reported from dll. Type int.
    /// Use DEBUG_LEVEL class to set parameter.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.DEBUG_LEVEL, out int val)
    /// </remarks>
    public const string DEBUG_LEVEL = "debug_level";

    /// <summary>
    /// Return device system instance path.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_INSTANCE_PATH, string val)
    /// </remarks>
    public const string DEVICE_INSTANCE_PATH = "device_inst_path";

    /// <summary>
    /// Represents the location of the device in the device tree.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_LOCATION_PATH, string val)
    /// </remarks>
    public const string DEVICE_LOCATION_PATH = "device_loc_path";

    /// <summary>
    /// Set/Get custom device ID string. Type string.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_USER_ID, string val)
    /// </remarks>
    public const string DEVICE_USER_ID = "device_user_id";

    /// <summary>
    /// Return device capability description XML. Type string.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_USER_ID, string val)
    /// </remarks>
    public const string DEVICE_MANIFEST = "device_manifest";

    /// <summary>
    /// User image data at image header to track parameters synchronization.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.IMAGE_USER_DATA, out int val)
    /// </remarks>
    public const string IMAGE_USER_DATA = "image_user_data";

    /// <summary>
    /// Get device ID string. Type string.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_ID, string val)
    /// </remarks>
    public const string DEVICE_ID = "device_id";

    /// <summary>
    /// Enable/disable automatic bus speed adjusting on device init. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AUTO_BANDWIDTH_CALCULATION, int val)
    /// </remarks>
    public const string AUTO_BANDWIDTH_CALCULATION = "auto_bandwidth_calculation";

    /// <summary>
    /// Enable/disable Enables (2015/FAPI) processing chain for MQ MU cameras. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.NEW_PROCESS_CHAIN_ENABLE, int val)
    /// </remarks>
    public const string NEW_PROCESS_CHAIN_ENABLE = "new_process_chain_enable";

    /// <summary>
    /// Returns device serial number in string.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DEVICE_SN, out string val)
    /// </remarks>
    public const string DEVICE_SN = "device_sn";

    /// <summary>
    /// Returns sensor serial number in string
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(DEVICE_SENS_SN, out string val)
    /// </remarks>
    public const string DEVICE_SENS_SN = "device_sens_sn";

    /// <summary>
    /// Set/Get exposure time in microseconds. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.EXPOSURE, out int val) or
    /// xiCam.SetParam(PRM.EXPOSURE, int val)
    /// </remarks>
    public const string EXPOSURE = "exposure";

    /// <summary>
    /// Set exposure time in microseconds with direct update flag to be applied immediately. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.EXPOSURE, int val)
    /// </remarks>
    public const string EXPOSURE_DIRECT_UPDATE = "exposure:direct_update";

    /// <summary>
    /// Get longest possible exposure to be set on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.EXPOSURE_MAX, out int val)
    /// </remarks>
    public const string EXPOSURE_MAX = "exposure:max";

    /// <summary>
    /// Get shortest possible exposure to be set on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.EXPOSURE_MIN, out int val)
    /// </remarks>
    public const string EXPOSURE_MIN = "exposure:min";

    /// <summary>
    /// Set/Get the number of times of exposure in one frame. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.EXPOSURE_BURST_COUNT, out int val) or
    /// xiCam.SetParam(PRM.EXPOSURE_BURST_COUNT, int val)
    /// </remarks>
    public const string EXPOSURE_BURST_COUNT = "exposure_burst_count";

    /// <summary>
    /// Select gain type to control with GAIN. Use class GAIN_SELECTOR_TYPE to set value. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.GAIN_SELECTOR, out int val)
    /// </remarks>
    public const string GAIN_SELECTOR = "gain_selector";

    /// <example></example>
    /// <summary>
    /// Set/Get camera gain in dB. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GAIN, out float val) or
    /// xiCam.SetParam(PRM.GAIN, float val)
    /// </remarks>
    public const string GAIN = "gain";

    /// <example></example>
    /// <summary>
    /// Set camera gain in dB with direct update flag to be applied immediately. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.GAIN, float val)
    /// </remarks>
    public const string GAIN_DIRECT_UPDATE = "gain:direct_update";

    /// <example></example>
    /// <summary>
    /// Get highest possible camera gain in dB. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GAIN_MAX, out float val)
    /// </remarks>
    public const string GAIN_MAX = "gain:max";

    /// <summary>
    /// Get lowest possible camera gain in dB. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GAIN_MIN, out float val)
    /// </remarks>
    public const string GAIN_MIN = "gain:min";

    /// <summary>
    /// Set/Get image resolution by binning or skipping. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DOWNSAMPLING, out int val) or
    /// xiCam.SetParam(PRM.DOWNSAMPLING, int val)
    /// </remarks>
    public const string DOWNSAMPLING = "downsampling";

    /// <summary>
    /// Get highest value for binning or skipping. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DOWNSAMPLING_MAX, out int val)
    /// </remarks>
    public const string DOWNSAMPLING_MAX = "downsampling:max";

    /// <summary>
    /// Get lowest value for binning or skipping. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DOWNSAMPLING_MIN, out int val)
    /// </remarks>
    public const string DOWNSAMPLING_MIN = "downsampling:min";

    /// <summary>
    /// Change image downsampling type. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DOWNSAMPLING_TYPE, out int val)
    /// xiCam.SetParam(PRM.DOWNSAMPLING_TYPE, out int val)
    /// </remarks>
    public const string DOWNSAMPLING_TYPE = "downsampling_type";

    /// <summary>
    /// Select Binning engine to configure. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BINNING_SELECTOR, out int val)
    /// xiCam.SetParam(PRM.BINNING_SELECTOR, in int val)
    /// </remarks>
    public const string BINNING_SELECTOR = "binning_selector";

    /// <summary>
    /// Selects the mode to use to combine horizontal pixel together. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BINNING_HORIZONTAL_MODE, out int val)
    /// xiCam.SetParam(PRM.BINNING_HORIZONTAL_MODE, in int val)
    /// </remarks>
    public const string BINNING_HORIZONTAL_MODE = "binning_horizontal_mode";

    /// <summary>
    /// Selects the mode to use to combine vertical pixel together. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BINNING_VERTICAL_MODE, out int val)
    /// xiCam.SetParam(PRM.BINNING_VERTICAL_MODE, in int val)
    /// </remarks>
    public const string BINNING_VERTICAL_MODE = "binning_vertical_mode";

    /// <summary>
    /// Defines number of vertical photo-sensitive cells to combine. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BINNING_VERTICAL, out int val)
    /// xiCam.SetParam(PRM.BINNING_VERTICAL, in int val)
    /// </remarks>
    public const string BINNING_VERTICAL = "binning_vertical";

    /// <summary>
    /// Defines number of horizontal photo-sensitive cells to combine. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BINNING_HORIZONTAL, out int val)
    /// xiCam.SetParam(PRM.BINNING_HORIZONTAL, in int val)
    /// </remarks>
    public const string BINNING_HORIZONTAL = "binning_horizontal";

    /// <summary>
    /// Defines binning horizontal pattern. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BINNING_HORIZONTAL_PATTERN, out int val)
    /// xiCam.SetParam(PRM.BINNING_HORIZONTAL_PATTERN, in int val)
    /// </remarks>
    public const string BINNING_HORIZONTAL_PATTERN = "binning_horizontal_pattern";

    /// <summary>
    /// Defines binning vertical pattern. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BINNING_VERTICAL_PATTERN, out int val)
    /// xiCam.SetParam(PRM.BINNING_VERTICAL_PATTERN, in int val)
    /// </remarks>
    public const string BINNING_VERTICAL_PATTERN = "binning_vertical_pattern";

    /// <summary>
    /// Select Decimation engine to configure. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DECIMATION_SELECTOR, out int val)
    /// xiCam.SetParam(PRM.DECIMATION_SELECTOR, in int val)
    /// </remarks>
    public const string DECIMATION_SELECTOR = "decimation_selector";

    /// <summary>
    /// Reduces the vertical resolution of the image by the specified decimation factor. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DECIMATION_VERTICAL, out int val)
    /// xiCam.SetParam(PRM.DECIMATION_VERTICAL, in int val)
    /// </remarks>
    public const string DECIMATION_VERTICAL = "decimation_vertical";

    /// <summary>
    /// Reduces the horizontal resolution of the image by the specified decimation factor. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DECIMATION_HORIZONTAL, out int val)
    /// xiCam.SetParam(PRM.DECIMATION_HORIZONTAL, in int val)
    /// </remarks>
    public const string DECIMATION_HORIZONTAL = "decimation_horizontal";

    /// <summary>
    /// Defines decimation horizontal pattern. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DECIMATION_HORIZONTAL_PATTERN, out int val)
    /// xiCam.SetParam(PRM.DECIMATION_HORIZONTAL_PATTERN, in int val)
    /// </remarks>
    public const string DECIMATION_HORIZONTAL_PATTERN = "decimation_horizontal_pattern";

    /// <summary>
    /// Defines decimation vertical pattern. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.DECIMATION_VERTICAL_PATTERN, out int val)
    /// xiCam.SetParam(PRM.DECIMATION_VERTICAL_PATTERN, in int val)
    /// </remarks>
    public const string DECIMATION_VERTICAL_PATTERN = "decimation_vertical_pattern";

    /// <summary>
    /// Selects which test pattern generator is controlled by the TestPattern feature. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TEST_PATTERN_GENERATOR_SELECTOR, out int val)
    /// xiCam.SetParam(PRM.TEST_PATTERN_GENERATOR_SELECTOR, in int val)
    /// </remarks>
    public const string TEST_PATTERN_GENERATOR_SELECTOR = "test_pattern_generator_selector";

    /// <summary>
    /// Selects which test pattern type is generated by the selected generator. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TEST_PATTERN, out int val)
    /// xiCam.SetParam(PRM.TEST_PATTERN, in int val)
    /// </remarks>
    public const string TEST_PATTERN = "test_pattern";

    /// <summary>
    /// Change sensor shutter type(CMOS sensor). Use class SHUTTER_TYPE to set value. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SHUTTER_TYPE, out int val)
    /// xiCam.SetParam(PRM.SHUTTER_TYPE, out int val)
    /// </remarks>
    public const string SHUTTER_TYPE = "shutter_type";

    /// <summary>
    /// Set/Get output image data format. Use class IMG_FORMAT to set value. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.IMAGE_DATA_FORMAT, out int val) or
    /// xiCam.SetParam(PRM.IMAGE_DATA_FORMAT, int val)
    ///             </remarks>
    public const string IMAGE_DATA_FORMAT = "imgdataformat";

    /// <summary>
    /// Set/Get the alpha channel of RGB32 output image format. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.IMAGE_DATA_FORMAT_RGB32_ALPHA, out int val) or
    /// xiCam.SetParam(PRM.IMAGE_DATA_FORMAT_RGB32_ALPHA, int val)
    ///             </remarks>
    public const string IMAGE_DATA_FORMAT_RGB32_ALPHA = "imgdataformatrgb32alpha";

    /// <summary>
    /// Current Image payload size in bytes. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.IMAGE_PAYLOAD_SIZE, out int val) or
    /// xiCam.SetParam(PRM.IMAGE_PAYLOAD_SIZE, int val)
    ///             </remarks>
    public const string IMAGE_PAYLOAD_SIZE = "imgpayloadsize";

    /// <summary>
    /// Type of pixel format on transport layer
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TRANSPORT_PIXEL_FORMAT, out int val)
    ///             </remarks>
    public const string TRANSPORT_PIXEL_FORMAT = "transport_pixel_format";

    /// <summary>
    /// Selector for transport data target (CPU RAM or GPU RAM)
    /// Use TRANSPORT_DATA_TARGET_MODE
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TRANSPORT_DATA_TARGET, out int val)
    ///             </remarks>
    public const string TRANSPORT_DATA_TARGET = "transport_data_target";

    /// <summary>
    /// Set/Get number of sensor taps. Supported only by MD camera family. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_TAPS, out int val) or
    /// xiCam.SetParam(PRM.SENSOR_TAPS, int val)
    ///             </remarks>
    public const string SENSOR_TAPS = "sensor_taps";

    /// <summary>
    /// Set/Get sensor clock frequency in Hz.  Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_CLOCK_FREQ_HZ, out int val) or
    /// xiCam.SetParam(PRM.SENSOR_CLOCK_FREQ_HZ, int val)
    ///             </remarks>
    public const string SENSOR_CLOCK_FREQ_HZ = "sensor_clock_freq_hz";

    /// <summary>
    /// Sensor clock frequency index (available for some sensors). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_CLOCK_FREQ_INDEX, out int val) or
    /// xiCam.SetParam(PRM.SENSOR_CLOCK_FREQ_INDEX, int val)
    ///             </remarks>
    public const string SENSOR_CLOCK_FREQ_INDEX = "sensor_clock_freq_index";

    /// <summary>
    /// Sensor output data channel count.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_OUTPUT_CHANNEL_COUNT, out int val) or
    /// xiCam.SetParam(PRM.SENSOR_OUTPUT_CHANNEL_COUNT, int val)
    ///             </remarks>
    public const string SENSOR_OUTPUT_CHANNEL_COUNT = "sensor_output_channel_count";

    /// <summary>
    /// Set/Get sensor output data bit depth. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_DATA_BIT_DEPTH, out int val) or
    /// xiCam.SetParam(PRM.SENSOR_DATA_BIT_DEPTH, int val)
    ///             </remarks>
    public const string SENSOR_DATA_BIT_DEPTH = "sensor_bit_depth";

    /// <summary>
    /// Set/Get device output data bit depth. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OUTPUT_DATA_BIT_DEPTH, out int val) or
    /// xiCam.SetParam(PRM.OUTPUT_DATA_BIT_DEPTH, int val)
    ///             </remarks>
    public const string OUTPUT_DATA_BIT_DEPTH = "output_bit_depth";

    /// <summary>
    /// Set/Get bitdepth of data returned by function xiGetImage. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.IMAGE_DATA_BIT_DEPTH, out int val) or
    /// xiCam.SetParam(PRM.IMAGE_DATA_BIT_DEPTH, int val)
    ///             </remarks>
    public const string IMAGE_DATA_BIT_DEPTH = "image_data_bit_depth";

    /// <summary>
    /// Set/Get Device output data packing (or grouping) enabled. Packing could be enabled if output_data_bit_depth &gt; 8 and packing is available. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OUTPUT_DATA_PACKING, out int val) or
    /// xiCam.SetParam(PRM.OUTPUT_DATA_PACKING, int val)
    ///             </remarks>
    public const string OUTPUT_DATA_PACKING = "output_bit_packing";

    /// <summary>
    /// Set/Get Device output data packing (or grouping) type. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OUTPUT_DATA_PACKING_TYPE, out int val) or
    /// xiCam.SetParam(PRM.OUTPUT_DATA_PACKING_TYPE, int val)
    ///             </remarks>
    public const string OUTPUT_DATA_PACKING_TYPE = "output_bit_packing_type";

    /// <summary>
    /// Returns 1 for color cameras. By default -. Type Int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.IMAGE_IS_COLOR, out int val) or
    /// xiCam.SetParam(PRM.IMAGE_IS_COLOR, int val)
    ///             </remarks>
    public const string IMAGE_IS_COLOR = "iscolor";

    /// <summary>
    /// Returns color filter array type of RAW data. By default -. Type Int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.COLOR_FILTER_ARRAY, out int val) or
    /// xiCam.SetParam(PRM.COLOR_FILTER_ARRAY, int val)
    ///             </remarks>
    public const string COLOR_FILTER_ARRAY = "cfa";

    /// <summary>
    /// Get frames per second. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.FRAMERATE, out float val)
    /// </remarks>
    public const string FRAMERATE = "framerate";

    /// <summary>
    /// Get highest possible framerate for current camera settings. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.FRAMERATE_MAX, out float val)
    /// </remarks>
    public const string FRAMERATE_MAX = "framerate:max";

    /// <summary>
    /// Get lowest framerate for current camera settings. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.FRAMERATE_MIN, out float val)
    /// </remarks>
    public const string FRAMERATE_MIN = "framerate:min";

    /// <summary>
    /// Type of sensor frames timing. Use ACQ_TIMING_MODE class to set/get values. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.ACQ_TIMING_MODE, float val)
    /// xiCam.GetParam(PRM.ACQ_TIMING_MODE, out float val)
    /// </remarks>
    public const string ACQ_TIMING_MODE = "acq_timing_mode";

    /// <summary>
    /// Select frames counter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.COUNTER_SELECTOR, out int val)
    /// </remarks>
    public const string COUNTER_SELECTOR = "counter_selector";

    /// <summary>
    /// Get frames counter status. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.COUNTER_VALUE, out int val)
    /// </remarks>
    public const string COUNTER_VALUE = "counter_value";

    /// <summary>
    /// Calculate and return available interface bandwidth(int Megabits). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.AVAILABLE_BANDWIDTH, int val)
    /// </remarks>
    public const string AVAILABLE_BANDWIDTH = "available_bandwidth";

    /// <summary>
    /// Get highest possible bandwidth for current camera settings. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.AVAILABLE_BANDWIDTH_MAX, int val)
    /// </remarks>
    public const string AVAILABLE_BANDWIDTH_MAX = "available_bandwidth:max";

    /// <summary>
    /// Get lowest bandwidth for current camera settings. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.AVAILABLE_BANDWIDTH_MIN, int val)
    /// </remarks>
    public const string AVAILABLE_BANDWIDTH_MIN = "available_bandwidth:min";

    /// <summary>
    /// Set/get bandwidth(datarate)(in Megabits)
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.AVAILABLE_BANDWIDTH, int val)
    /// </remarks>
    public const string LIMIT_BANDWIDTH = "limit_bandwidth";

    /// <summary>
    /// Get highest possible bandwidth for current camera settings. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.AVAILABLE_BANDWIDTH_MAX, int val)
    /// </remarks>
    public const string LIMIT_BANDWIDTH_MAX = "limit_bandwidth:max";

    /// <summary>
    /// Get lowest bandwidth for current camera settings. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.AVAILABLE_BANDWIDTH_MIN, int val)
    /// </remarks>
    public const string LIMIT_BANDWIDTH_MIN = "limit_bandwidth:min";

    /// <summary> 
    /// Enable Limit Bandwidth. Default 1(enabled). When Auto bandwidth measurement is disabled 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.LIMIT_BANDWIDTH_MODE, int val);
    /// xiCam.GetParam(PRM.LIMIT_BANDWIDTH_MODE, out int val);
    /// </remarks>
    public const string LIMIT_BANDWIDTH_MODE = "limit_bandwidth_mode";

    /// <summary>
    /// Data move policy
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BUFFER_POLICY, out float val)
    /// xiCam.SetParam(PRM.BUFFER_POLICY, int val)
    /// </remarks>
    public const string BUFFER_POLICY = "buffer_policy";

    /// <summary>
    /// Set/Get horizontal offset from the origin to the area of interest (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OFFSET_X, out int val) or
    /// xiCam.SetParam(PRM.OFFSET_X, int val)
    /// </remarks>
    public const string OFFSET_X = "offsetX";

    /// <summary>
    /// Get maximum horizontal offset from the origin to the area of interest (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OFFSET_X_MAX, out int val)
    /// </remarks>
    public const string OFFSET_X_MAX = "offsetX:max";

    /// <summary>
    /// Get minimum horizontal offset from the origin to the area of interest (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OFFSET_X_MIN, out int val) 
    /// </remarks>
    public const string OFFSET_X_MIN = "offsetX:min";

    /// <summary>
    /// Set/Get vertical offset from the origin to the area of interest (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OFFSET_Y, out int val) or
    /// xiCam.SetParam(PRM.OFFSET_Y, int val)
    /// </remarks>
    public const string OFFSET_Y = "offsetY";

    /// <summary>
    /// Get maximum vertical offset from the origin to the area of interest (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OFFSET_Y_MAX, out int val)
    /// </remarks>
    public const string OFFSET_Y_MAX = "offsetY:max";

    /// <summary>
    /// Get minimal vertical offset from the origin to the area of interest (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.OFFSET_Y_MIN, out int val)
    /// </remarks>
    public const string OFFSET_Y_MIN = "offsetY:min";

    /// <summary>
    /// Set/Get width of the image provided by the camera (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.WIDTH, out int val) or
    /// xiCam.SetParam(PRM.WIDTH, int val)
    /// </remarks>
    public const string WIDTH = "width";

    /// <summary>
    /// Get maximal image width provided by the camera (in pixels). Type int. 
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.WIDTH_MAX, out int val)
    /// </remarks>
    public const string WIDTH_MAX = "width:max";

    /// <summary>
    /// Get minimal image width provided by the camera (in pixels). Type int. 
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.WIDTH_MIN, out int val)
    /// </remarks>
    public const string WIDTH_MIN = "width:min";

    /// <summary>
    /// Set/Get height of the image provided by the camera (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.HEIGHT, out int val) or
    /// xiCam.SetParam(PRM.HEIGHT, int val)
    /// </remarks>
    public const string HEIGHT = "height";

    /// <summary>
    /// Get maximal image height provided by the camera (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.HEIGHT_MAX, out int val)
    /// </remarks>
    public const string HEIGHT_MAX = "height:max";

    /// <summary>
    /// Get minimal image height provided by the camera (in pixels). Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.HEIGHT_MIN, out int val)
    /// </remarks>
    public const string HEIGHT_MIN = "height:min";

    /// <summary>
    /// Selects Region in Multiple ROI which parameters are set by width, height, ... ,region mode. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.REGION_SELECTOR, out int val) or
    /// xiCam.SetParam(PRM.REGION_SELECTOR, int val)
    /// </remarks>
    public const string REGION_SELECTOR = "region_selector";

    /// <summary>
    /// Get maximal region selector provided by the camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.REGION_SELECTOR_MAX, out int val)
    /// </remarks>
    public const string REGION_SELECTOR_MAX = "region_selector:max";

    /// <summary>
    /// Get minimal region selector provided by the camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.REGION_SELECTOR_MIN, out int val)
    /// </remarks>
    public const string REGION_SELECTOR_MIN = "region_selector:min";

    /// <summary>
    /// Activates/deactivates Region selected by Region Selector. Type int. 0-inactive, 1-active
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.REGION_MODE, out int val) or
    /// xiCam.SetParam(PRM.REGION_MODE, int val)
    /// </remarks>
    public const string REGION_MODE = "region_mode";

    /// <summary>
    /// Get maximal mode (is 1) active region. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.REGION_MODE_MAX, out int val)
    /// </remarks>
    public const string REGION_MODE_MAX = "region_mode:max";

    /// <summary>
    /// Get minimal mode (is 0) inactive region. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.REGION_MODE_MIN, out int val)
    /// </remarks>
    public const string REGION_MODE_MIN = "region_mode:min";

    /// <summary>
    /// Activates horizontal flip if available in camera. Currently available only some MQ cameras models.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.HORIZONTAL_FLIP, out int val) or
    /// xiCam.SetParam(PRM.HORIZONTAL_FLIP, int val)
    /// </remarks>
    public const string HORIZONTAL_FLIP = "horizontal_flip";

    /// <summary>
    /// Activates vertical flip if available in camera. Currently available only some MQ cameras models.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.VERTICAL_FLIP, out int val) or
    /// xiCam.SetParam(PRM.VERTICAL_FLIP, int val)
    /// </remarks>
    public const string VERTICAL_FLIP = "vertical_flip";

    /// <summary>
    /// Activates look up table. Currently available only for Currera-R cameras and MQ cameras.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LUT_EN, out int val) or
    /// xiCam.SetParam(PRM.LUT_EN, int val)
    /// </remarks>
    public const string LUT_EN = "LUTEnable";

    /// <summary>
    /// Controls the index (offset) of the coefficient to access in the LUT. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LUT_INDEX, out int val) or
    /// xiCam.SetParam(PRM.LUT_INDEX, int val)
    /// </remarks>
    public const string LUT_INDEX = "LUTIndex";

    /// <summary>
    /// Get highest LUT index (offset) of the coefficient to access in the LUT. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LUT_INDEX_MAX, out int val)
    /// </remarks>
    public const string LUT_INDEX_MAX = "LUTIndex:max";

    /// <summary>
    /// Get lowest LUT index (offset) of the coefficient to access in the LUT. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LUT_INDEX_MIN, out int val)
    /// </remarks>
    public const string LUT_INDEX_MIN = "LUTIndex:min";

    /// <summary>
    /// Set/Get value at entry LUTIndex of the LUT. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LUT_VALUE, out int val) or
    /// xiCam.SetParam(PRM.LUT_VALUE, int val)
    /// </remarks>
    public const string LUT_VALUE = "LUTValue";

    /// <summary>
    /// Get highest value to be set in LUT. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LUT_VALUE_MAX, out int val)
    /// </remarks>
    public const string LUT_VALUE_MAX = "LUTValue:max";

    /// <summary>
    /// Get lowest value to be set in LUT. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LUT_VALUE_MIN, out int val)
    /// </remarks>
    public const string LUT_VALUE_MIN = "LUTValue:min";

    /// <summary>
    /// Set/Get source of trigger. Use TRG_SOURCE class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TRG_SOURCE, out int val) or
    /// xiCam.SetParam(PRM.TRG_SOURCE, int val)
    /// </remarks>
    public const string TRG_SOURCE = "trigger_source";

    /// <summary>
    /// Set/Get type of trigger. Use TRG_SELECTOR class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TRG_SELECTOR, out int val) or
    /// xiCam.SetParam(PRM.TRG_SELECTOR, int val)
    /// </remarks>
    public const string TRG_SELECTOR = "trigger_selector";

    /// <summary>
    /// Set/Get type of trigger overlap. Use TRG_OVERLAP class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TRG_OVERLAP, out int val) or
    /// xiCam.SetParam(PRM.TRG_OVERLAP, int val)
    /// </remarks>
    public const string TRG_OVERLAP = "trigger_overlap";

    /// <summary>
    /// Set an internal software trigger. PRM.TRG_SOURCE must be set to TRG_SOFTWARE. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.TRG_SOFTWARE, int val)
    /// </remarks>
    public const string TRG_SOFTWARE = "trigger_software";

    /// <summary>
    /// Specifies the delay in microseconds (us) to apply after the trigger reception before activating it. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TRG_DELAY, out int val)
    /// xiCam.SetParam(PRM.TRG_DELAY, int val)
    /// </remarks>
    public const string TRG_DELAY = "trigger_delay";

    /// <summary>
    /// Select camera GPI port. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPI_SELECTOR, out int val) or
    /// xiCam.SetParam(PRM.GPI_SELECTOR, int val)
    /// </remarks>
    public const string GPI_SELECTOR = "gpi_selector";

    /// <summary>
    /// Get highest GPI port number on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPI_SELECTOR_MAX, out int val)
    /// </remarks>
    public const string GPI_SELECTOR_MAX = "gpi_selector:max";

    /// <summary>
    /// Get lowest GPI port number on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPI_SELECTOR_MIN, out int val)
    /// </remarks>
    public const string GPI_SELECTOR_MIN = "gpi_selector:min";

    /// <summary>
    /// Get current GPI level. By default -. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPI_LEVEL, out int val) or
    /// </remarks>
    public const string GPI_LEVEL = "gpi_level";

    /// <summary>
    /// Set/Get GPI functionality. Select port by using GPI_SELECTOR parameter. 
    /// Use GPI_MODE class to set mode. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPI_MODE, out int val) or
    /// xiCam.SetParam(PRM.GPI_MODE, int val)
    /// </remarks>
    public const string GPI_MODE = "gpi_mode";

    /// <summary>
    /// Select camera GPO port. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPO_SELECTOR, out int val) or
    /// xiCam.SetParam(PRM.GPO_SELECTOR, int val)
    /// </remarks>
    public const string GPO_SELECTOR = "gpo_selector";

    /// <summary>
    /// Get highest GPO port number on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPO_SELECTOR_MAX, out int val)
    /// </remarks>
    public const string GPO_SELECTOR_MAX = "gpo_selector:max";

    /// <summary>
    /// Get lowest GPI port number on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPO_SELECTOR_MIN, out int val)
    /// </remarks>
    public const string GPO_SELECTOR_MIN = "gpo_selector:min";

    /// <summary>
    /// Set/Get GPO functionality. Select port by using GPO_SELECTOR parameter.
    /// Use GPO_MODE class to set mode. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GPO_MODE, out int val) or
    /// xiCam.SetParam(PRM.GPO_MODE, int val)
    /// </remarks>
    public const string GPO_MODE = "gpo_mode";

    /// <summary>
    /// Selects camera LED to be used. Currently supported only for Currera-R cameras. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LED_SELECTOR, out int val) or
    /// xiCam.SetParam(PRM.LED_SELECTOR, int val)
    /// </remarks>
    public const string LED_SELECTOR = "led_selector";

    /// <summary>
    /// Get highest LED number on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LED_SELECTOR_MAX, out int val)
    /// </remarks>
    public const string LED_SELECTOR_MAX = "led_selector:max";

    /// <summary>
    /// Get lowest LED number on camera. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LED_SELECTOR_MIN, out int val)
    /// </remarks>
    public const string LED_SELECTOR_MIN = "led_selector:min";

    /// <summary>
    /// Set/Get LED functionality. Select port by using LED_SELECTOR parameter. 
    /// Use LED_MODE class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.LED_MODE, out int val) or
    /// xiCam.SetParam(PRM.LED_MODE, int val)
    /// </remarks>
    public const string LED_MODE = "led_mode";

    /// <summary>
    /// Defines how time stamp reset engine will be armed
    /// Use TS_RST_MODE class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TS_RST_MODE, out int val) or
    /// xiCam.SetParam(PRM.TS_RST_MODE, int val)
    /// </remarks>
    public const string TS_RST_MODE = "ts_rst_mode";

    /// <summary>
    /// Defines which source will be used for timestamp reset. Writing this parameter will trigger settings of engine (arming)
    /// Use TS_RST_SOURCE class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.TS_RST_SOURCE, out int val) or
    /// xiCam.SetParam(PRM.TS_RST_SOURCE, int val)
    /// </remarks>
    public const string TS_RST_SOURCE = "ts_rst_source";

    /// <summary>
    /// Sets number of frames acquired by burst. This burst is used only if trigger is set to FrameBurstStart. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_FRAME_BURST_COUNT, out int val) or
    /// xiCam.SetParam(PRM.ACQ_FRAME_BURST_COUNT, int val)
    /// </remarks>
    public const string ACQ_FRAME_BURST_COUNT = "acq_frame_burst_count";

    /// <summary>
    /// Returns 1 if camera connected and works properly.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.IS_DEVICE_EXIST, out int val) or
    /// </remarks>
    public const string IS_DEVICE_EXIST = "isexist";

    /// <summary>
    /// Acquisition buffer size in bytes.
    /// By default 53248000. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_BUFFER_SIZE, out int val) or
    /// xiCam.SetParam(PRM.ACQ_BUFFER_SIZE, int val)
    /// </remarks>
    public const string ACQ_BUFFER_SIZE = "acq_buffer_size";

    /// <summary>
    /// Acquisition buffer size unit in bytes.
    /// By default 1. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_BUFFER_SIZE_UNIT, out int val) or
    /// xiCam.SetParam(PRM.ACQ_BUFFER_SIZE_UNIT, int val)
    /// </remarks>
    public const string ACQ_BUFFER_SIZE_UNIT = "acq_buffer_size_unit";

    /// <summary>
    /// Acquisition transport buffer size in bytes.
    /// By default 1048576. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_TRANSPORT_BUFFER_SIZE, out int val) or
    /// xiCam.SetParam(PRM.ACQ_TRANSPORT_BUFFER_SIZE, int val)
    /// </remarks>
    public const string ACQ_TRANSPORT_BUFFER_SIZE = "acq_transport_buffer_size";

    /// <summary>
    /// Get highest value for acquisition transport buffer size in bytes. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_TRANSPORT_BUFFER_SIZE_MAX, out int val)
    /// </remarks>
    public const string ACQ_TRANSPORT_BUFFER_SIZE_MAX = "acq_transport_buffer_size:max";

    /// <summary>
    /// Get lowest value for acquisition transport buffer size in bytes. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_TRANSPORT_BUFFER_SIZE_MIN, out int val)
    /// </remarks>
    public const string ACQ_TRANSPORT_BUFFER_SIZE_MIN = "acq_transport_buffer_size:min";

    /// <summary>
    /// Acquisition transport packet size in bytes.
    /// By default defined by interface . Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_TRANSPORT_PACKET_SIZE, out int val) or
    /// xiCam.SetParam(PRM.ACQ_TRANSPORT_PACKET_SIZE, int val)
    /// </remarks>
    public const string ACQ_TRANSPORT_PACKET_SIZE = "acq_transport_packet_size";

    /// <summary>
    /// Image queue count
    /// By default 4. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BUFFERS_QUEUE_SIZE, out int val) or
    /// xiCam.SetParam(PRM.BUFFERS_QUEUE_SIZE, int val)
    /// </remarks>
    public const string BUFFERS_QUEUE_SIZE = "buffers_queue_size";

    /// <summary>
    /// Get highest value for image queue count. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BUFFERS_QUEUE_SIZE_MAX, out int val)
    /// </remarks>
    public const string BUFFERS_QUEUE_SIZE_MAX = "buffers_queue_size:max";

    /// <summary>
    /// Get lowest value for image queue count. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.BUFFERS_QUEUE_SIZE_MIN, out int val)
    /// </remarks>
    public const string BUFFERS_QUEUE_SIZE_MIN = "buffers_queue_size:min";

    /// <summary>
    /// Number of buffers to commit to low level
    /// By default -. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_TRANSPORT_BUFFER_COMMIT, out int val) or
    /// xiCam.SetParam(PRM.ACQ_TRANSPORT_BUFFER_COMMIT, int val)
    /// </remarks>
    public const string ACQ_TRANSPORT_BUFFER_COMMIT = "acq_transport_buffer_commit";

    /// <summary>
    /// Get highest value of buffers to commit to low level count. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_TRANSPORT_BUFFER_COMMIT_MAX, out int val)
    /// </remarks>
    public const string ACQ_TRANSPORT_BUFFER_COMMIT_MAX = "acq_transport_buffer_commit:max";

    /// <summary>
    /// Get lowest value of buffers to commit to low level count. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQ_TRANSPORT_BUFFER_COMMIT_MIN, out int val)
    /// </remarks>
    public const string ACQ_TRANSPORT_BUFFER_COMMIT_MIN = "acq_transport_buffer_commit:min";

    /// <summary>
    /// GetImage returns most recent frame.
    /// By default 0. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.RECENT_FRAME, out int val) or
    /// xiCam.SetParam(PRM.RECENT_FRAME, int val)
    /// </remarks>
    public const string RECENT_FRAME = "recent_frame";

    /// <summary>
    /// Reset device command.
    /// By default 0. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.DEVICE_RESET, int val)
    /// </remarks>
    public const string DEVICE_RESET = "device_reset";

    /// <summary>
    /// Initialize/uninitialize CMS. By default CMS_MODE.DIS. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CMS, out int val) or
    /// xiCam.SetParam(PRM.CMS, int val)
    /// </remarks>
    public const string CMS = "cms";

    /// <summary>
    /// CMS intent. By default CMS_INTENT_PERCEPTUAL. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CMS_INTENT, out int val) or
    /// xiCam.SetParam(PRM.CMS_INTENT, int val)
    /// </remarks>
    public const string CMS_INTENT = "cms_intent";

    /// <summary>
    /// Apply CMS profiles(input.icc and output.icm), perceptual inetent. By default 0. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.APPLY_CMS, out int val) or
    /// xiCam.SetParam(PRM.APPLY_CMS, int val)
    /// </remarks>
    public const string APPLY_CMS = "apply_cms";

    /// <summary>
    /// Apply input CMS profile. Type string.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.INPUT_CMS_PROFILE, string val)
    /// </remarks>
    public const string INPUT_CMS_PROFILE = "input_cms_profile";

    /// <summary>
    /// Apply output CMS profile. Type string.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.OUTPUT_CMS_PROFILE, string val)
    /// </remarks>
    public const string OUTPUT_CMS_PROFILE = "output_cms_profile";

    /// <summary>
    /// White balance red coefficient. By default 1. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.WB_KR, out float val) or
    /// xiCam.SetParam(PRM.WB_KR, float val)
    /// </remarks>
    public const string WB_KR = "wb_kr";

    /// <summary>
    /// White balance green coefficient. By default 1. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.WB_KG, out float val) or
    /// xiCam.SetParam(PRM.WB_KG, float val)
    /// </remarks>
    public const string WB_KG = "wb_kg";

    /// <summary>
    /// White balance blue coefficient. By default 1. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.WB_KB, out float val) or
    /// xiCam.SetParam(PRM.WB_KB, float val)
    /// </remarks>
    public const string WB_KB = "wb_kb";

    /// <summary>
    ///             Calculates White Balance. By default -. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.MANUAL_WB, 0)
    /// </remarks>
    public const string MANUAL_WB = "manual_wb";

    /// <summary>
    /// Automatic white balance. By default 0. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.AUTO_WB, out int val)
    /// xiCam.SetParam(PRM.AUTO_WB, int val)
    /// </remarks>
    public const string AUTO_WB = "auto_wb";

    /// <summary>
    /// Luminosity gamma. By default 1.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GAMMAY, out float val) or
    /// xiCam.SetParam(PRM.GAMMAY, float val)
    /// </remarks>
    public const string GAMMAY = "gammaY";

    /// <summary>
    /// Chromaticity gamma. By default 0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.GAMMAC, out float val) or
    /// xiCam.SetParam(PRM.GAMMAC, float val)
    /// </remarks>
    public const string GAMMAC = "gammaC";

    /// <summary>
    /// Sharpness strenght. By default 0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SHARPNESS, out float val) or
    /// xiCam.SetParam(PRM.SHARPNESS, float val)
    /// </remarks>
    public const string SHARPNESS = "sharpness";

    /// <summary>
    /// Color Correction Matrix element [0][0]. By default 1.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_00, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_00, float val)
    /// </remarks>
    public const string CC_MATRIX_00 = "ccMTX00";

    /// <summary>
    /// Color Correction Matrix element [0][1]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_01, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_01, float val)
    /// </remarks>
    public const string CC_MATRIX_01 = "ccMTX01";

    /// <summary>
    /// Color Correction Matrix element [0][2]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_02, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_02, float val)
    /// </remarks>
    public const string CC_MATRIX_02 = "ccMTX02";

    /// <summary>
    /// Color Correction Matrix element [0][3]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_03, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_03, float val)
    /// </remarks>
    public const string CC_MATRIX_03 = "ccMTX03";

    /// <summary>
    /// Color Correction Matrix element [1][0]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_10, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_10, float val)
    /// </remarks>
    public const string CC_MATRIX_10 = "ccMTX10";

    /// <summary>
    /// Color Correction Matrix element [1][1]. By default 1.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_11, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_11, float val)
    /// </remarks>
    public const string CC_MATRIX_11 = "ccMTX11";

    /// <summary>
    /// Color Correction Matrix element [1][2]. By default 0.0. Type float. 
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_12, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_12, float val)
    /// </remarks>
    public const string CC_MATRIX_12 = "ccMTX12";

    /// <summary>
    /// Color Correction Matrix element [1][3]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_13, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_13, float val)
    /// </remarks>
    public const string CC_MATRIX_13 = "ccMTX13";

    /// <summary>
    /// Color Correction Matrix element [2][0]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_20, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_20, float val)
    /// </remarks>
    public const string CC_MATRIX_20 = "ccMTX20";

    /// <summary>
    /// Color Correction Matrix element [2][1]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_21, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_21, float val)
    /// </remarks>
    public const string CC_MATRIX_21 = "ccMTX21";

    /// <summary>
    /// Color Correction Matrix element [2][2]. By default 1.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_22, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_22, float val)
    /// </remarks>
    public const string CC_MATRIX_22 = "ccMTX22";

    /// <summary>
    /// Color Correction Matrix element [2][3]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_23, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_23, float val)
    /// </remarks>
    public const string CC_MATRIX_23 = "ccMTX23";

    /// <summary>
    /// Color Correction Matrix element [3][0]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_30, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_30, float val)
    /// </remarks>
    public const string CC_MATRIX_30 = "ccMTX30";

    /// <summary>
    /// Color Correction Matrix element [3][1]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_31, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_31, float val)
    /// </remarks>
    public const string CC_MATRIX_31 = "ccMTX31";

    /// <summary>
    /// Color Correction Matrix element [3][2]. By default 1.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_32, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_32, float val)
    /// </remarks>
    public const string CC_MATRIX_32 = "ccMTX32";

    /// <summary>
    /// Color Correction Matrix element [3][3]. By default 0.0. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.CC_MATRIX_33, out float val) or
    /// xiCam.SetParam(PRM.CC_MATRIX_33, float val)
    /// </remarks>
    public const string CC_MATRIX_33 = "ccMTX33";

    /// <summary> 
    /// Default Color Correction Matrix.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.DEFAULT_CC_MATRIX, int val)
    /// </remarks>
    public const string DEFAULT_CC_MATRIX = "defccMTX";

    /// <summary> 
    /// Start automatic exposure/gain. By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AEAG, int val)
    /// xiCam.GetParam(PRM.AEAG, out int val)
    /// </remarks>
    public const string AEAG = "aeag";

    /// <summary> 
    /// Exposure priority (0.5 - exposure 50%, gain 50%). By default 0.8. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.EXP_PRIORITY, float val)
    /// xiCam.GetParam(PRM.EXP_PRIORITY, out float val)
    /// </remarks>
    public const string EXP_PRIORITY = "exp_priority";

    /// <summary> 
    /// Maximum limit of exposure in AEAG procedure. By default 1000000(1s). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AE_MAX_LIMIT, int val)
    /// xiCam.GetParam(PRM.AE_MAX_LIMIT, out int val)
    /// </remarks>
    public const string AE_MAX_LIMIT = "ae_max_limit";

    /// <summary> 
    /// Maximum limit of gain in AEAG procedure. By default defined by sensor. Type float.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AG_MAX_LIMIT, float val)
    /// xiCam.GetParam(PRM.AG_MAX_LIMIT, out float val)
    /// </remarks>
    public const string AG_MAX_LIMIT = "ag_max_limit";

    /// <summary> 
    /// Average intensity of output signal AEAG should achieve(in ). By default 40(). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AEAG_LEVEL, int val);
    /// xiCam.GetParam(PRM.AEAG_LEVEL, out int val);
    /// </remarks>
    public const string AEAG_LEVEL = "aeag_level";

    /// <summary>
    /// Automatic exposure/gain ROI offset X. Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AEAG_ROI_OFFSET_X, int val);
    /// xiCam.GetParam(PRM.AEAG_ROI_OFFSET_X, out int val);
    /// </remarks>
    public const string AEAG_ROI_OFFSET_X = "aeag_roi_offset_x";

    /// <summary>
    /// Automatic exposure/gain ROI offset Y. Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AEAG_ROI_OFFSET_Y, int val);
    /// xiCam.GetParam(PRM.AEAG_ROI_OFFSET_Y, out int val);
    /// </remarks>
    public const string AEAG_ROI_OFFSET_Y = "aeag_roi_offset_y";

    /// <summary>
    /// Automatic exposure/gain ROI Width. Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AEAG_ROI_WIDTH, int val);
    /// xiCam.GetParam(PRM.AEAG_ROI_WIDTH, out int val);
    /// </remarks>
    public const string AEAG_ROI_WIDTH = "aeag_roi_width";

    /// <summary>
    /// Automatic exposure/gain ROI Height. Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.AEAG_ROI_HEIGHT, int val);
    /// xiCam.GetParam(PRM.AEAG_ROI_HEIGHT, out int val);
    /// </remarks>
    public const string AEAG_ROI_HEIGHT = "aeag_roi_height";

    /// <summary>
    /// Sensor defects correction list selector. Could be used for selection of list for enabling particular lists
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.SENS_DEFECTS_CORR_LIST_SELECTOR, int val);
    /// xiCam.GetParam(PRM.SENS_DEFECTS_CORR_LIST_SELECTOR, out int val);
    /// </remarks>
    public const string SENS_DEFECTS_CORR_LIST_SELECTOR = "bpc_list_selector";

    /// <summary>
    ///  Read file from camera flash filesystem. 
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.SENS_DEFECTS_CORR_LIST_CONTENT, in string val)
    ///  xiCam.GetParam(PRM.SENS_DEFECTS_CORR_LIST_CONTENT, out string val)
    /// </remarks>
    public const string SENS_DEFECTS_CORR_LIST_CONTENT = "sens_defects_corr_list_content";

    /// <summary>
    /// Sensor defects correction enable/disable. By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.SENS_DEFECTS_CORR, int val);
    /// xiCam.GetParam(PRM.SENS_DEFECTS_CORR, out int val);
    /// </remarks>
    public const string SENS_DEFECTS_CORR = "bpc";

    public const string BPC = "bpc";

    /// <summary>
    /// Enable image flat field correction. By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.FFC, int val);
    /// xiCam.GetParam(PRM.FFC, out int val);
    /// </remarks>
    public const string FFC = "ffc";

    /// <summary>
    ///  Set name of file of image flat field to be applied for FFC processor(in tiff format).  By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.FFC_FLAT_FIELD_FILE_NAME, int val);
    /// xiCam.GetParam(PRM.FFC_FLAT_FIELD_FILE_NAME, out int val);
    /// </remarks>
    public const string FFC_FLAT_FIELD_FILE_NAME = "ffc_flat_field_file_name";

    /// <summary>
    ///  Set name of file of image dark field to be applied for FFC processor(in tiff format).  By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.FFC_DARK_FIELD_FILE_NAME, int val);
    /// xiCam.GetParam(PRM.FFC_DARK_FIELD_FILE_NAME, out int val);
    /// </remarks>
    public const string FFC_DARK_FIELD_FILE_NAME = "ffc_dark_field_file_name";

    /// <summary>
    /// Enable correction of column fpn. By default 0(enabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.COLUMN_FPN_CORRECTION, int val);
    /// xiCam.GetParam(PRM.COLUMN_FPN_CORRECTION, out int val);
    /// </remarks>
    public const string COLUMN_FPN_CORRECTION = "column_fpn_correction";

    /// <summary>
    /// Enable correction of row fpn. By default 0(enabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.ROW_FPN_CORRECTION, int val);
    /// xiCam.GetParam(PRM.ROW_FPN_CORRECTION, out int val);
    /// </remarks>
    public const string ROW_FPN_CORRECTION = "row_fpn_correction";

    /// <summary>
    /// Enable/Disable debounce to selected GPI. By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.DEBOUNCE_EN, int val);
    /// xiCam.GetParam(PRM.DEBOUNCE_EN, out int val);
    /// </remarks>
    public const string DEBOUNCE_EN = "dbnc_en";

    /// <summary>
    /// Debounce time (x * 10us). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.DEBOUNCE_T0, int val);
    /// xiCam.GetParam(PRM.DEBOUNCE_T0, out int val);
    /// </remarks>
    public const string DEBOUNCE_T0 = "dbnc_t0";

    /// <summary>
    /// Debounce time (x * 10us). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.DEBOUNCE_T1, int val);
    /// xiCam.GetParam(PRM.DEBOUNCE_T1, out int val);
    /// </remarks>
    public const string DEBOUNCE_T1 = "dbnc_t1";

    /// <summary>
    /// Debounce polarity (pol = 1 t0 - falling edge, t1 - rising edge). By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    /// xiCam.SetParam(PRM.DEBOUNCE_POL, int val);
    /// xiCam.GetParam(PRM.DEBOUNCE_POL, out int val);
    /// </remarks>
    public const string DEBOUNCE_POL = "dbnc_pol";

    /// <summary>
    ///  Returns 1 for cameras that support cooling.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.IS_COOLED, out int val);
    /// </remarks>
    public const string IS_COOLED = "iscooled";

    /// <summary>
    ///  Enable or disable camera temperature control. By default 0. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.COOLING, int val);
    ///  xiCam.GetParam(PRM.COOLING, out int val);
    /// </remarks>
    public const string COOLING = "cooling";

    /// <summary>
    ///  Set sensor target temperature for cooling. By default 20. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.TARGET_TEMP, float val);
    ///  xiCam.GetParam(PRM.TARGET_TEMP, out float val);
    /// </remarks>
    public const string TARGET_TEMP = "target_temp";

    /// <summary>
    ///  Camera thermometer selector. By default -. Type int.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.TEMP_SELECTOR, int val);
    ///  xiCam.GetParam(PRM.TEMP_SELECTOR, out int val);
    /// </remarks>
    public const string TEMP_SELECTOR = "temp_selector";

    /// <summary>
    ///  Camera temperature. By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.TEMP, float val);
    ///  xiCam.GetParam(PRM.TEMP, out float val);
    /// </remarks>
    public const string TEMP = "temp";

    /// <summary>
    ///  Camera chip temperature. By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.CHIP_TEMP, float val);
    ///  xiCam.GetParam(PRM.CHIP_TEMP, out float val);
    /// </remarks>
    public const string CHIP_TEMP = "chip_temp";

    /// <summary>
    ///  Camera housing tepmerature. By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.HOUS_TEMP, float val);
    ///  xiCam.GetParam(PRM.HOUS_TEMP, out float val);
    /// </remarks>
    public const string HOUS_TEMP = "hous_temp";

    /// <summary>
    ///  Camera housing back side tepmerature. By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.HOUS_BACK_SIDE_TEMP, float val);
    ///  xiCam.GetParam(PRM.HOUS_BACK_SIDE_TEMP, out float val);
    /// </remarks>
    public const string HOUS_BACK_SIDE_TEMP = "hous_back_side_temp";

    /// <summary>
    ///  Camera sensor board tepmerature. By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.SENSOR_BOARD_TEMP, float val);
    ///  xiCam.GetParam(PRM.SENSOR_BOARD_TEMP, out float val);
    /// </remarks>
    public const string SENSOR_BOARD_TEMP = "sensor_board_temp";

    /// <summary>
    ///  Temperature control mode. Type int.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.TEMP_CONTROL_MODE, int val);
    ///  xiCam.GetParam(PRM.TEMP_CONTROL_MODE, out int val);
    /// </remarks>
    public const string TEMP_CONTROL_MODE = "device_temperature_ctrl_mode";

    /// <summary>
    ///  Camera temperature element selector. By default -. Type int.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.TEMP_ELEMENT_SEL, int val);
    ///  xiCam.GetParam(PRM.TEMP_ELEMENT_SEL, out int val);
    /// </remarks>
    public const string TEMP_ELEMENT_SEL = "device_temperature_element_sel";

    /// <summary>
    ///  Temperature element value in percents of full control range. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.TEMP_ELEMENT_VALUE, float val);
    ///  xiCam.GetParam(PRM.TEMP_ELEMENT_VALUE, out float val);
    /// </remarks>
    public const string TEMP_ELEMENT_VALUE = "device_temperature_element_val";

    /// <summary>
    ///  Current sensor mode. Allows to select sensor mode by one integer. Setting of this parameter affects: image dimensions and downsampling.. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.SENSOR_MODE, int val);
    ///  xiCam.GetParam(PRM.SENSOR_MODE, out int val);
    /// </remarks>
    public const string SENSOR_MODE = "sensor_mode";

    /// <summary>
    ///  Enable High Dynamic Range feature. By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.HDR, int val);
    ///  xiCam.GetParam(PRM.HDR, out int val);
    /// </remarks>
    public const string HDR = "hdr";

    /// <summary>
    ///  Number of kneepoints in  PWLR. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.HDR_KNEEPOINT_COUNT, int val);
    ///  xiCam.GetParam(PRM.HDR_KNEEPOINT_COUNT, out int val);
    /// </remarks>
    public const string HDR_KNEEPOINT_COUNT = "hdr_kneepoint_count";

    /// <summary>
    ///  Enable High Dynamic Range feature. By default 0(disabled). Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.HDR_T1, int val);
    ///  xiCam.GetParam(PRM.HDR_T1, out int val);
    /// </remarks>
    public const string HDR_T1 = "hdr_t1";

    /// <summary>
    ///  Exposure time of first slope(in microseconds). By default 40000us. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.HDR_T2, int val);
    ///  xiCam.GetParam(PRM.HDR_T2, out int val);
    /// </remarks>
    public const string HDR_T2 = "hdr_t2";

    /// <summary>
    ///  First kneepoint (% of sensor saturation) By default 60%. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.HDR_T3, int val);
    ///  xiCam.GetParam(PRM.HDR_T3, out int val);
    /// </remarks>
    public const string KNEEPOINT1 = "hdr_kneepoint1";

    /// <summary>
    ///  Second kneepoint (% of sensor saturation) By default 40%. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.KNEEPOINT2, int val);
    ///  xiCam.GetParam(PRM.KNEEPOINT2, out int val);
    /// </remarks>
    public const string KNEEPOINT2 = "hdr_kneepoint2";

    /// <summary>
    ///  black level of last image. Can be used for Offline processing . Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.IMAGE_BLACK_LEVEL, int val);
    ///  xiCam.GetParam(PRM.IMAGE_BLACK_LEVEL, out int val);
    /// </remarks>
    public const string IMAGE_BLACK_LEVEL = "image_black_level";

    /// <summary>
    ///  Return the version of current API
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.API_VERSION, out string val)
    /// </remarks>
    public const string API_VERSION = "api_version";

    /// <summary>
    ///  Return version of current device driver. 
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.DRV_VERSION, out string val)
    /// </remarks>
    public const string DRV_VERSION = "drv_version";

    /// <summary>
    ///  Returns version of MCU firmware.
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.MCU1_VERSION, out string val)
    /// </remarks>
    public const string MCU1_VERSION = "version_mcu1";

    /// <summary>
    ///  Returns version of MCU2 firmware.
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.MCU2_VERSION, out string val)
    /// </remarks>
    public const string MCU2_VERSION = "version_mcu2";

    /// <summary>
    ///  Returns version of MCU3 firmware.
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.MCU3_VERSION, out string val)
    /// </remarks>
    public const string MCU3_VERSION = "version_mcu3";

    /// <summary>
    ///  Returns version of FPGA firmware.
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.FPGA1_VERSION, out string val)
    /// </remarks>
    public const string FPGA1_VERSION = "version_fpga1";

    /// <summary>
    ///  Returns version of XML manifest.
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.XMLMAN_VERSION, out string val)
    /// </remarks>
    public const string XMLMAN_VERSION = "version_xmlman";

    /// <summary>
    ///  Returns hardware revision number of camera.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.HW_REVISION, out int val)
    /// </remarks>
    public const string HW_REVISION = "hw_revision";

    /// <summary>
    ///  Read file from camera flash filesystem. 
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.READ_FILE_FFS, out string val)
    /// </remarks>
    public const string READ_FILE_FFS = "read_file_ffs";

    /// <summary>
    ///  Write file to camera flash filesystem. 
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.WRITE_FILE_FFS, out string val)
    /// </remarks>
    public const string WRITE_FILE_FFS = "write_file_ffs";

    /// <summary>
    ///  Set name of file to be written/read from camera FFS.
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.FFS_FILE_NAME, out string val)
    ///  xiCam.SetParam(PRM.FFS_FILE_NAME, out string val)
    /// </remarks>
    public const string FFS_FILE_NAME = "ffs_file_name";

    /// <summary>
    ///  File number(id) in FFS. 
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.FFS_FILE_ID, in int val)
    ///  xiCam.GetParam(PRM.FFS_FILE_ID, out int val)
    /// </remarks>
    public const string FFS_FILE_ID = "ffs_file_id";

    /// <summary>
    ///  Size of file in FFS. 
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.FFS_FILE_SIZE, out int val)
    /// </remarks>
    public const string FFS_FILE_SIZE = "ffs_file_size";

    /// <summary>
    ///  Size of free camera FFS. 
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.FREE_FFS_SIZE, out int val)
    /// </remarks>
    public const string FREE_FFS_SIZE = "free_ffs_size";

    /// <summary>
    ///  Size of used camera FFS. 
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.USED_FFS_SIZE, out int val)
    /// </remarks>
    public const string USED_FFS_SIZE = "used_ffs_size";

    /// <summary>
    ///  Setting of key enables file operations on some cameras.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.FFS_ACCESS_KEY, out int key)
    /// </remarks>
    public const string FFS_ACCESS_KEY = "ffs_access_key";

    /// <summary>
    ///  Status of lens control interface. This shall be set to XI_ON before any Lens operations.
    ///  Use LENS_MODE class to set parameter.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.LENS_MODE, int mode)
    /// </remarks>
    public const string LENS_MODE = "lens_mode";

    /// <summary>
    ///  Current lens aperture value in stops. Examples: 2.8, 4, 5.6, 8, 11
    ///  By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.LENS_APERTURE_VALUE, float aperture_value)
    /// </remarks>
    public const string LENS_APERTURE_VALUE = "lens_aperture_value";

    /// <summary>
    ///  Lens current focus movement value to be used by LENS_FOCUS_MOVE in motor steps.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.LENS_FOCUS_MOVEMENT_VALUE, int motor_steps_count)
    /// </remarks>
    public const string LENS_FOCUS_MOVEMENT_VALUE = "lens_focus_movement_value";

    /// <summary>
    ///  Moves lens focus motor by steps set in LENS_FOCUS_MOVEMENT_VALUE.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.LENS_FOCUS_MOVE, int any_value)
    /// </remarks>
    public const string LENS_FOCUS_MOVE = "lens_focus_move";

    /// <summary>
    ///  Lens focus distance in cm.
    ///  By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.LENS_FOCUS_DISTANCE, out float distance_cm)
    /// </remarks>
    public const string LENS_FOCUS_DISTANCE = "lens_focus_distance";

    /// <summary>
    ///  Lens focal distance in mm.
    ///  By default -. Type float.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.LENS_FOCAL_LENGTH, out float focal_distance_cm)
    /// </remarks>
    public const string LENS_FOCAL_LENGTH = "lens_focal_length";

    /// <summary>
    ///  Selects the current feature which is accessible by LENS_FEATURE.
    ///  Use LENS_FEATURE_SELECTOR class to set parameter.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.LENS_FEATURE_SELECTOR, int feature_id)
    /// </remarks>
    public const string LENS_FEATURE_SELECTOR = "lens_feature_selector";

    /// <summary>
    ///  Allows access to lens feature value currently selected by LENS_FEATURE_SELECTOR.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.SetParam(PRM.LENS_FEATURE, int feature_value)
    /// </remarks>
    public const string LENS_FEATURE = "lens_feature";

    /// <summary>
    /// Selects the current feature which is accessible by SENSOR_FEATURE_VALUE. SENSOR_FEATURE_SELECTOR
    /// Use SENSOR_FEATURE_SELECTOR class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_FEATURE_SELECTOR, out int select_id) or
    /// xiCam.SetParam(PRM.SENSOR_FEATURE_SELECTOR, int select_id)
    /// </remarks>
    public const string SENSOR_FEATURE_SELECTOR = "sensor_feature_selector";

    /// <summary>
    /// Allows access to sensor feature value currently selected by SENSOR_FEATURE_SELECTOR.
    /// All ranges depends on selected feature. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.SENSOR_FEATURE_VALUE, out int val) or
    /// xiCam.SetParam(PRM.SENSOR_FEATURE_VALUE, int val)
    /// </remarks>
    public const string SENSOR_FEATURE_VALUE = "sensor_feature_value";

    /// <summary>
    ///  List of current parameters settings context - parameters with values. Used for offline processing.
    ///  By default -. Type string.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.API_CONTEXT_LIST out string val)
    ///  xiCam.SetParam(PRM.API_CONTEXT_LIST, string val)
    /// </remarks>
    public const string API_CONTEXT_LIST = "xiapi_context_list";

    /// <summary>
    /// Selects the internal acquisition signal to read using ACQUISITION_STATUS.
    /// Use ACQUISITION_STATUS_SELECTOR class to set parameter. Type int.
    /// </summary>
    /// <remarks>
    /// xiCam.GetParam(PRM.ACQUISITION_STATUS_SELECTOR, out int select_id) or
    /// xiCam.SetParam(PRM.ACQUISITION_STATUS_SELECTOR, int select_id)
    /// </remarks>
    public const string ACQUISITION_STATUS_SELECTOR = "acquisition_status_selector";

    /// <summary>
    ///  Acquisition status.
    ///  By default -. Type integer.
    /// </summary>
    /// <remarks>
    ///  xiCam.GetParam(PRM.ACQUISITION_STATUS, out feature_value)
    /// </remarks>
    public const string ACQUISITION_STATUS = "acquisition_status";
  }

  // xiApi.NET.SENS_DEFFECTS_CORR_LIST_SELECTOR
  /// <summary>
  /// Enumerator for sensor defects correction list selector
  /// </summary>
  public static class SENS_DEFFECTS_CORR_LIST_SELECTOR
  {
    /// <summary>Sensor defect correction list created while camera production process</summary>
    public const int XI_SENS_DEFFECTS_CORR_LIST_SEL_FACTORY = 0;

    /// <summary>Sensor defect correction list created by user in specific conditions or with special defects</summary>
    public const int XI_SENS_DEFFECTS_CORR_LIST_SEL_USER0 = 1;
  }

  // xiApi.NET.SENSOR_FEATURE_SELECTOR
  /// <summary>
  /// Possible values for sensor feature selector
  /// </summary>
  public static class SENSOR_FEATURE_SELECTOR
  {
    /// <summary>Zero ROT enable for ONSEMI PYTHON family.</summary>
    public const int SENSOR_FEATURE_ZEROROT_ENABLE = 0;
  }

  // xiApi.NET.SHUTTER_TYPE
  /// <summary>
  /// Switch between sensor shutter types, to be used with the PRM.SHUTTER_TYPE function parameter.
  /// </summary>
  public static class SHUTTER_TYPE
  {
    /// <summary>
    /// Sensor Global Shutter(CMOS sensor).
    /// </summary>
    public const int SHUTTER_GLOBAL = 0;

    /// <summary>
    /// Sensor Electronic Rolling Shutter(CMOS sensor).
    /// </summary>
    public const int SHUTTER_ROLLING = 1;

    /// <summary>
    /// Sensor Global Reset Release Shutter(CMOS sensor).
    /// </summary>
    public const int SHUTTER_GLOBAL_RESET_RELEASE = 2;
  }

  // xiApi.NET.TEMP_CONTROL_MODE
  /// <summary>
  /// Enumerator for temperature control mode
  /// </summary>
  public static class TEMP_CONTROL_MODE
  {
    /// <summary>Temperature controlling is disabled (no fan or TEC (peltier) is enabled)</summary>
    public const int TEMP_CTRL_MODE_OFF = 0;

    /// <summary>Automated temperature controlling is enabled - based on selected thermomether and target temperature.</summary>
    public const int TEMP_CTRL_MODE_AUTO = 1;

    /// <summary>Manual controlling of temperature elements is enabled. Application can control the elements.</summary>
    public const int XI_TEMP_CTRL_MODE_MANUAL = 2;
  }

  // xiApi.NET.TEMP_ELEMENT_SELECTOR
  /// <summary>
  /// Enumerator for temperature element selector
  /// </summary>
  public static class TEMP_ELEMENT_SELECTOR
  {
    /// <summary>Temperature element TEC1 (peltier closest to sensor)</summary>
    public const int XI_TEMP_ELEM_TEC1 = 11;

    /// <summary>Temperature element TEC2</summary>
    public const int XI_TEMP_ELEM_TEC2 = 12;

    /// <summary>Temperature element fan current or rotation</summary>
    public const int XI_TEMP_ELEM_FAN1 = 31;
  }

  // xiApi.NET.TEMP_SELECTOR
  /// <summary>
  /// Enumerator for temperature selector
  /// </summary>
  public static class TEMP_SELECTOR
  {
    /// <summary>Selects not calibrated temperature of image sensor</summary>
    public const int TEMP_IMAGE_SENSOR_RAW = 0;

    /// <summary>Selects calibrated temperature of image sensor</summary>
    public const int TEMP_IMAGE_SENSOR = 1;

    /// <summary>Selects sensor board temperature</summary>
    public const int TEMP_SENSOR_BOARD = 2;

    /// <summary>Selects interface board temperature</summary>
    public const int TEMP_INTERFACE_BOARD = 3;

    /// <summary>Selects front part of camera housing temperature</summary>
    public const int TEMP_FRONT_HOUSING = 4;

    /// <summary>Selects back part of camera housing temperature</summary>
    public const int TEMP_BACK_HOUSING = 5;
  }

  // xiApi.NET.TEST_PATTERN
  /// <summary>
  /// Selects which test pattern type is used on the selected generator.
  /// </summary>
  public static class TEST_PATTERN
  {
    /// <summary>
    /// Testpattern turned off
    /// </summary>
    public const int OFF = 0;

    /// <summary>
    /// Image is filled with darkest possible image.
    /// </summary>
    public const int BLACK = 1;

    /// <summary>
    /// Image is filled with brightest possible image.
    /// </summary>
    public const int WHITE = 2;

    /// <summary>
    /// Image is filled horizontally with an image that goes from the darkest possible value to the brightest.
    /// </summary>
    public const int GREY_HORIZ_RAMP = 3;

    /// <summary>
    /// Image is filled vertically with an image that goes from the darkest possible value to the brightest.
    /// </summary>
    public const int GREY_VERT_RAMP = 4;

    /// <summary>
    /// Image is filled horizontally with an image that goes from the darkest possible value to the brightest and moves from left to right.
    /// </summary>
    public const int GREY_HORIZ_RAMP_MOVING = 5;

    /// <summary>
    /// Image is filled vertically with an image that goes from the darkest possible value to the brightest and moves from left to right.
    /// </summary>
    public const int GREY_VERT_RAMP_MOVING = 6;

    /// <summary>
    /// A moving horizontal line is superimposed on the live image.
    /// </summary>
    public const int HORIZ_LINE_MOVING = 7;

    /// <summary>
    /// A moving vertical line is superimposed on the live image.
    /// </summary>
    public const int VERT_LINE_MOVING = 8;

    /// <summary>
    /// Image is filled with stripes of color including White, Black, Red, Green, Blue, Cyan, Magenta and Yellow.
    /// </summary>
    public const int COLOR_BAR = 9;

    /// <summary>
    /// A frame counter is superimposed on the live image.
    /// </summary>
    public const int FRAME_COUNTER = 10;

    /// <summary>
    /// On some devices (PCIe) it is 128bit counter.
    /// </summary>
    public const int DEVICE_SPEC_COUNTER = 11;
  }

  // xiApi.NET.TEST_PATTERN_GENERATOR_SELECTOR
  /// <summary>
  /// Selects which test pattern generator is used.
  /// </summary>
  public static class TEST_PATTERN_GENERATOR_SELECTOR
  {
    /// <summary>
    /// Sensor test pattern generator engine selected (if available)
    /// </summary>
    public const int SENSOR = 0;

    /// <summary>
    /// FPGA test pattern generator engine selected (if available)
    /// </summary>
    public const int FPGA = 1;
  }

  // xiApi.NET.TRANSPORT_DATA_TARGET_MODE
  /// <summary>
  /// Enumerator for data target modes
  /// </summary>
  public static class TRANSPORT_DATA_TARGET_MODE
  {
    /// <summary>Selects CPU RAM</summary>
    public const int CPU_RAM = 0;

    /// <summary>Selects GPU RAM</summary>
    public const int GPU_RAM = 1;
  }

  // xiApi.NET.TRG_OVERLAP
  /// <summary>
  /// Definitions containing information about trigger overlap
  /// </summary>
  public static class TRG_OVERLAP
  {
    /// <summary> No trigger overlap is permitted. If camera is in read-out phase, all triggers are rejected.</summary>
    public const int OFF = 0;

    /// <summary> Trigger is accepted only when sensor is ready to start next exposure with defined exposure time. Trigger is rejected when sensor is not ready for new exposure with defined exposure time.</summary>
    public const int READ_OUT = 1;

    /// <summary> Trigger is accepted by camera any time. If sensor is not ready for the next exposure – the trigger is latched and sensor starts exposure as soon as exposure can be started with defined exposure time.</summary>
    public const int PREV_FRAME = 2;
  }

  // xiApi.NET.TRG_SELECTOR
  /// <summary>
  /// Definitions containing information about trigger functionality.
  /// </summary>
  public static class TRG_SELECTOR
  {
    /// <summary> Selects a trigger starting the capture of one frame.</summary>
    public const int FRAME_START = 0;

    /// <summary> Selects a trigger controlling the duration of one frame.</summary>
    public const int EXPOSURE_ACTIVE = 1;

    /// <summary> Selects a trigger starting the capture of the bursts of frames in an acquisition.</summary>
    public const int FRAME_BURST_START = 2;

    /// <summary> Selects a trigger controlling the duration of the capture of the bursts of frames in an acquisition.</summary>
    public const int FRAME_BURST_ACTIVE = 3;
  }

  // xiApi.NET.TRG_SOURCE
  /// <summary>
  /// Definitions for camera trigger functionality.
  /// </summary>
  public static class TRG_SOURCE
  {
    /// <summary> Camera works in free run mode.</summary>
    public const int OFF = 0;

    /// <summary> External trigger (rising edge).</summary>
    public const int EDGE_RISING = 1;

    /// <summary> External trigger (falling edge).</summary>
    public const int EDGE_FALLING = 2;

    /// <summary> Software(manual) trigger.</summary>
    public const int SOFTWARE = 3;
  }

  // xiApi.NET.TS_RST_MODE
  /// <summary>
  /// Time stamp reset arming options
  /// </summary>
  public static class TS_RST_MODE
  {
    /// <summary> TimeStamp reset is armed once, after execution engine is disabled.</summary>
    public const int TS_RST_ARM_ONCE = 0;

    /// <summary> TimeStamp reset is armed permanently if source is selected.</summary>
    public const int TS_RST_ARM_PERSIST = 1;
  }

  // xiApi.NET.TS_RST_SOURCE
  /// <summary>
  /// possible timestamp reset sources
  /// </summary>
  public static class TS_RST_SOURCE
  {
    /// <summary> No source selected, timestamp reset effectively disabled.</summary>
    public const int TS_RST_OFF = 0;

    /// <summary> TimeStamp reset source selected GPI1 (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_1 = 1;

    /// <summary> TimeStamp reset source selected GPI2 (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_2 = 2;

    /// <summary> TimeStamp reset source selected GPI3 (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_3 = 3;

    /// <summary> TimeStamp reset source selected GPI4 (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_4 = 4;

    /// <summary> TimeStamp reset source selected GPI1 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_1_INV = 5;

    /// <summary> TimeStamp reset source selected GPI2 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_2_INV = 6;

    /// <summary> TimeStamp reset source selected GPI3 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_3_INV = 7;

    /// <summary> TimeStamp reset source selected GPI4 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPI_4_INV = 8;

    /// <summary> TimeStamp reset source selected GPO1 (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_1 = 9;

    /// <summary> TimeStamp reset source selected GPO2 (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_2 = 10;

    /// <summary> TimeStamp reset source selected GPO3 (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_3 = 11;

    /// <summary> TimeStamp reset source selected GPO4 (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_4 = 12;

    /// <summary> TimeStamp reset source selected GPO1 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_1_INV = 13;

    /// <summary> TimeStamp reset source selected GPO2 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_2_INV = 14;

    /// <summary> TimeStamp reset source selected GPO3 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_3_INV = 15;

    /// <summary> TimeStamp reset source selected GPO4 inverted (after de bounce).</summary>
    public const int TS_RST_SRC_GPO_4_INV = 16;

    /// <summary> TimeStamp reset source selected TRIGGER (signal for sensor).</summary>
    public const int TS_RST_SRC_TRIGGER = 17;

    /// <summary> TimeStamp reset source selected TRIGGER inverted (signal for sensor).</summary>
    public const int TS_RST_SRC_TRIGGER_INV = 18;

    /// <summary> TimeStamp reset source selected software (has immediate effect and is self cleared).</summary>
    public const int TS_RST_SRC_SW = 19;

    /// <summary> TimeStamp reset source selected exposure active.</summary>
    public const int TS_RST_SRC_EXPACTIVE = 20;

    /// <summary> TimeStamp reset source selected exposure active inverted.</summary>
    public const int TS_RST_SRC_EXPACTIVE_INV = 21;

    /// <summary> TimeStamp reset source selected frame valid signal from sensor.</summary>
    public const int TS_RST_SRC_FVAL = 22;

    /// <summary> TimeStamp reset source selected frame valid signal from sensor inverted.</summary>
    public const int TS_RST_SRC_FVAL_INV = 23;
  }


}
