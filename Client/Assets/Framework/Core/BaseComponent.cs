//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 14:01:15
//备    注：
//===================================================
using UnityEngine;

namespace USGame
{
    /// <summary>
    /// 框架组件基类
    /// </summary>
    public abstract class BaseComponent : MonoBehaviour
    {
        public int InstanceID { get; private set; }

        private void Awake()
        {
            InstanceID = GetInstanceID();
            OnAwake();
        }

        void Start()
        {
            OnStart();
        }

        protected virtual void OnAwake() { }
        protected virtual void OnStart() { }

        public abstract void Shutdown();
    }
}