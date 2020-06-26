//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 14:04:04
//备    注：
//===================================================

namespace USGame
{
    public class EventComponent : BaseComponent
    {
        /// <summary>
        /// 事件管理器
        /// </summary>
        private EventManager m_EventManager;

        /// <summary>
        /// 通用事件管理器
        /// </summary>
        public CommonEvent CommonEvent;

        /// <summary>
        /// 网络事件管理器
        /// </summary>
        public SocketEvent SocketEvent;

        protected override void OnAwake()
        {
            base.OnAwake();
            GameEntry.RegisterBaseComponent(this);
            m_EventManager = new EventManager();
            CommonEvent = m_EventManager.CommonEvent;
            SocketEvent = m_EventManager.SocketEvent;
        }

        public override void Shutdown()
        {
            m_EventManager.Dispose();
        }
    }
}