//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 13:32:03
//备    注：
//===================================================
using System;
using System.Collections.Generic;
using UnityEngine;

namespace USGame
{
    public partial class GameEntry : MonoBehaviour
    {
        #region 初始化基础组件
        /// <summary>
        /// 事件组件
        /// </summary>
        public static EventComponent Event { get; private set; }

        /// <summary>
        /// 初始化基础组件
        /// </summary>
        private void InitBaseComponents()
        {
            Event = GetBaseComponent<EventComponent>();
        }
        #endregion

        #region 基础组件管理
        /// <summary>
        /// 基础组件列表
        /// </summary>
        private static readonly LinkedList<BaseComponent> m_BaseComponentList = new LinkedList<BaseComponent>();

        /// <summary>
        /// 注册基础组件
        /// </summary>
        /// <param name="component"></param>
        internal static void RegisterBaseComponent(BaseComponent component)
        {
            //获取到组件类型
            Type type = component.GetType();

            LinkedListNode<BaseComponent> curr = m_BaseComponentList.First;
            while (curr != null)
            {
                if (curr.Value.GetType() == type) return;
                curr = curr.Next;
            }
            m_BaseComponentList.AddLast(component);
        }

        /// <summary>
        /// 泛型获取基础组件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetBaseComponent<T>() where T : BaseComponent
        {
            return (T)GetBaseComponent(typeof(T));
        }

        /// <summary>
        /// 获取基础组件
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static BaseComponent GetBaseComponent(Type type)
        {
            LinkedListNode<BaseComponent> curr = m_BaseComponentList.First;
            while (curr != null)
            {
                if (curr.Value.GetType() == type) return curr.Value;
                curr = curr.Next;
            }
            return null;
        }
        #endregion

        #region 更新组件管理
        /// <summary>
        /// 更新组件列表
        /// </summary>
        private static readonly LinkedList<IUpdateComponent> m_UpdateComponentList = new LinkedList<IUpdateComponent>();

        /// <summary>
        /// 注册更新组件
        /// </summary>
        internal static void RegisterUpdateComponent(IUpdateComponent component)
        {
            m_UpdateComponentList.AddLast(component);
        }

        /// <summary>
        /// 移除更新组件
        /// </summary>
        internal static void RemoveUpdateComponent(IUpdateComponent component)
        {
            m_UpdateComponentList.Remove(component);
        }
        #endregion

        void Start()
        {
            InitBaseComponents();
        }

        private void Update()
        {
            for (LinkedListNode<IUpdateComponent> curr = m_UpdateComponentList.First; curr != null; curr = curr.Next)
            {
                curr.Value.OnUpdate();
            }
        }

        private void OnDestroy()
        {
            for (LinkedListNode<BaseComponent> curr = m_BaseComponentList.First; curr != null; curr = curr.Next)
            {
                curr.Value.Shutdown();
            }
            m_UpdateComponentList.Clear();
            m_BaseComponentList.Clear();
        }
    }
}