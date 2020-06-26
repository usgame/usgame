//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 16:14:19
//备    注：
//===================================================
using System;
using UnityEngine;

namespace USGame
{
    public class TestEvent : MonoBehaviour
    {
        void Start()
        {
            //GameEntry.Event.CommonEvent.AddEventListener(CommonEventId.RegComplete, OnEventRegComplete);
            //GameEntry.Event.SocketEvent.AddEventListener(SocketEventId.CheckVersionBeginDownload, OnEventCheckVersionBeginDownload);
            GameEntry.AddCommonEventListener(CommonEventId.RegComplete, OnEventRegComplete);
            GameEntry.AddSocketEventListener(SocketEventId.CheckVersionBeginDownload, OnEventCheckVersionBeginDownload);
        }

        private void OnDestroy()
        {
            //GameEntry.Event.CommonEvent.RemoveEventListener(CommonEventId.RegComplete, OnEventRegComplete);
            //GameEntry.Event.SocketEvent.RemoveEventListener(SocketEventId.CheckVersionBeginDownload, OnEventCheckVersionBeginDownload);
            GameEntry.RemoveCommonEventListener(CommonEventId.RegComplete, OnEventRegComplete);
            GameEntry.RemoveSocketEventListener(SocketEventId.CheckVersionBeginDownload, OnEventCheckVersionBeginDownload);
        }

        private void OnEventRegComplete(object param)
        {
            Debug.Log("OnEventRegComplete: " + param.ToString());
        }

        private void OnEventCheckVersionBeginDownload(byte[] buffer)
        {
            Debug.Log("OnEventCheckVersionBeginDownload: " + System.Text.Encoding.UTF8.GetString(buffer));
        }

        public void OnButtonClick()
        {

            //GameEntry.Event.CommonEvent.Dispatch(CommonEventId.RegComplete, "hahaha");
            //GameEntry.Event.SocketEvent.Dispatch(SocketEventId.CheckVersionBeginDownload, System.Text.Encoding.UTF8.GetBytes("hahaha"));
            GameEntry.DispatchCommonEvent(CommonEventId.RegComplete, "hahaha");
            GameEntry.DispatchSocketEvent(SocketEventId.CheckVersionBeginDownload, System.Text.Encoding.UTF8.GetBytes("hahaha"));
        }
    }
}