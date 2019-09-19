using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace xiApi
{
  internal class ximeaApi
  {
    private const string xiapi_binary_name = "xiapi64.dll";

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiGetNumberDevices(int* numDevices);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiOpenDevice(int DevId, void** hDevice);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiCloseDevice(void* hDevice);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiStartAcquisition(void* hDevice);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiStopAcquisition(void* hDevice);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiGetImage(void* hDevice, int timeout, XI_IMG* img);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiSetParam(void* hDevice, string prm, void* val, int size, PRM_TYPE type);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiGetParam(void* hDevice, string prm, void* val, int* size, PRM_TYPE* type);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiGetDeviceInfoInt(int DevId, string prm, int* value);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiGetDeviceInfoString(int DevId, string prm, void* value, int value_size);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiProcOpen(void* processing_handle);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiProcSetParam(void* processing_handle, string prm, void* val, int size, PRM_TYPE type);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiProcGetParam(void* processing_handle, string prm, void* val, int* size, PRM_TYPE* type);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiProcPushImage(void* processing_handle, void* first_pixel);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiProcPushXiImg(void* processing_handle, XI_IMG* image);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiProcPullImage(void* processing_handle, int timeout, XI_IMG* image);

    [DllImport(xiapi_binary_name)]
    public unsafe static extern int xiProcClose(void* processing_handle);
  }
}
