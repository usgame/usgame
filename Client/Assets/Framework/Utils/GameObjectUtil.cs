//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 14:48:58
//备    注：
//===================================================
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace USGame
{
    /// <summary>
    /// U3D 游戏对象扩展
    /// </summary>
    public static class GameObjectUtil
    {
        /// <summary>
        /// 获取或创建组建
        /// </summary>
        public static T GetOrCreatComponent<T>(this GameObject obj) where T : MonoBehaviour
        {
            T t = obj.GetComponent<T>();
            if (t == null)
            {
                t = obj.AddComponent<T>();
            }
            return t;
        }

        /// <summary>
        /// 设置物体的父物体
        /// </summary>
        public static void SetParent(this GameObject obj, Transform parent)
        {
            obj.transform.parent = parent;
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = Vector3.one;
            obj.transform.localEulerAngles = Vector3.zero;
        }

        /// <summary>
        /// 设置物体的层
        /// </summary>
        public static void SetLayer(this GameObject obj, string layerName)
        {
            Transform[] transArr = obj.transform.GetComponentsInChildren<Transform>();
            for (int i = 0; i < transArr.Length; i++)
            {
                transArr[i].gameObject.layer = LayerMask.NameToLayer(layerName);
            }
        }

        /// <summary>
        /// 设置Text值
        /// </summary>
        public static void SetText(this Text txtObj, string text, bool isAnimation = false, float duration = 0.2f, ScrambleMode scrambleMode = ScrambleMode.None)
        {
            if (txtObj != null)
            {
                if (isAnimation)
                {
                    txtObj.text = "";
                    txtObj.DOText(text, duration, scrambleMode: scrambleMode);
                }
                else
                {
                    txtObj.text = text;
                }
            }
        }

        /// <summary>
        /// 设置滑动条的值
        /// </summary>
        public static void SetSliderValue(this Slider sliderObj, float value)
        {
            if (sliderObj != null)
            {
                sliderObj.value = value;
            }
        }

        /// <summary>
        /// 设置图片名称
        /// </summary>
        public static void SetImage(this Image imgObj, Sprite sprite)
        {
            if (imgObj != null)
            {
                imgObj.overrideSprite = sprite;
            }
        }
    }
}