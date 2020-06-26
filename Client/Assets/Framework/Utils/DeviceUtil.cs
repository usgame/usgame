//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 14:37:55
//备    注：
//===================================================
using UnityEngine;

namespace USGame
{
    public static class DeviceUtil
    {
        /// <summary>
        /// 获取设备标识符
        /// </summary>
        public static string DeviceIdentifier
        {
            get
            {
                return SystemInfo.deviceUniqueIdentifier;
            }
        }

        /// <summary>
        /// 获取设备型号
        /// </summary>
        public static string DeviceModel
        {
            get
            {
#if UNITY_IPHONE && !UNITY_EDITOR
                return Device.generation.ToString();
#else
                return SystemInfo.deviceModel;
#endif
            }
        }
    }
}