//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 17:01:53
//备    注：
//===================================================

namespace USGame
{
    /// <summary>
    /// GameEntry 部分类，简化事件调用
    /// </summary>
    public partial class GameEntry
    {
        #region 通用事件
        /// <summary>
        /// 监听通用事件
        /// </summary>
        public static void AddCommonEventListener(ushort key, CommonEvent.OnActionHandler handler)
        {
            Event.CommonEvent.AddEventListener(key, handler);
        }

        /// <summary>
        /// 移除监听通用事件
        /// </summary>
        public static void RemoveCommonEventListener(ushort key, CommonEvent.OnActionHandler handler)
        {
            Event.CommonEvent.RemoveEventListener(key, handler);
        }

        /// <summary>
        /// 派发通用事件
        /// </summary>
        public static void DispatchCommonEvent(ushort key, object userData = null)
        {
            Event.CommonEvent.Dispatch(key, userData);
        }
        #endregion

        #region 网络事件
        /// <summary>
        /// 监听网络事件
        /// </summary>
        public static void AddSocketEventListener(ushort key, SocketEvent.OnActionHandler handler)
        {
            Event.SocketEvent.AddEventListener(key, handler);
        }

        /// <summary>
        /// 移除监听网络事件
        /// </summary>
        public static void RemoveSocketEventListener(ushort key, SocketEvent.OnActionHandler handler)
        {
            Event.SocketEvent.RemoveEventListener(key, handler);
        }

        /// <summary>
        /// 派发网络事件
        /// </summary>
        public static void DispatchSocketEvent(ushort key, byte[] buffer = null)
        {
            Event.SocketEvent.Dispatch(key, buffer);
        }
        #endregion
    }
}