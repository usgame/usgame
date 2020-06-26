//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 13:53:49
//备    注：
//===================================================
using System;
using System.Collections.Generic;

namespace USGame
{
    /// <summary>
    /// 网络事件管理
    /// </summary>
    public class SocketEvent : IDisposable
    {
        public delegate void OnActionHandler(byte[] buffer);
        private Dictionary<ushort, LinkedList<OnActionHandler>> m_dic = new Dictionary<ushort, LinkedList<OnActionHandler>>();

        /// <summary>
        /// 添加监听
        /// </summary>
        /// <param name="key">事件Id</param>
        /// <param name="handler">事件回调函数</param>
        public void AddEventListener(ushort key, OnActionHandler handler)
        {
            LinkedList<OnActionHandler> handlerList = null;
            m_dic.TryGetValue(key, out handlerList);
            if (handlerList == null)
            {
                handlerList = new LinkedList<OnActionHandler>();
                m_dic.Add(key, handlerList);
            }
            handlerList.AddLast(handler);
        }

        /// <summary>
        /// 移除监听
        /// </summary>
        /// <param name="key">事件Id</param>
        /// <param name="handler">事件回调函数</param>
        public void RemoveEventListener(ushort key, OnActionHandler handler)
        {
            LinkedList<OnActionHandler> handlerList = null;
            m_dic.TryGetValue(key, out handlerList);
            if (handlerList != null)
            {
                handlerList.Remove(handler);
                if (handlerList.Count == 0)
                {
                    m_dic.Remove(key);
                }
            }
        }

        /// <summary>
        /// 派发事件
        /// </summary>
        /// <param name="key">事件Id</param>
        /// <param name="userData">网络数据</param>
        public void Dispatch(ushort key, byte[] buffer = null)
        {
            LinkedList<OnActionHandler> handlerList = null;
            m_dic.TryGetValue(key, out handlerList);
            if (handlerList != null)
            {
                for (LinkedListNode<OnActionHandler> curr = handlerList.First; curr != null; curr = curr.Next)
                {
                    OnActionHandler handler = curr.Value;
                    if (handler != null)
                    {
                        handler(buffer);
                    }
                }
            }
        }

        /// <summary>
        /// 销毁时清除数据
        /// </summary>
        public void Dispose()
        {
            m_dic.Clear();
        }
    }
}