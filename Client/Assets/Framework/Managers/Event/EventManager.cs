//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 13:54:27
//备    注：
//===================================================
using System;

namespace USGame
{
    public class EventManager : BaseManager, IDisposable
    {
        /// <summary>
        /// 管理通用事件
        /// </summary>
        public CommonEvent CommonEvent { get; private set; }

        /// <summary>
        /// 管理Socket事件
        /// </summary>
        public SocketEvent SocketEvent { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public EventManager()
        {
            CommonEvent = new CommonEvent();
            SocketEvent = new SocketEvent();
        }

        /// <summary>
        /// 管理器销毁时调用
        /// </summary>
        public void Dispose()
        {
            CommonEvent.Dispose();
            SocketEvent.Dispose();
        }
    }
}