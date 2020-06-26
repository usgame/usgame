//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 16:56:35
//备    注：
//===================================================

namespace USGame
{
    /// <summary>
    /// GameEntry部分类，简化日志调用
    /// </summary>
    public partial class GameEntry
    {
        #region 打印日志
        public static void Log(LogCategory category, string message)
        {
            switch (category)
            {
                default:
                case LogCategory.Normal:
#if DEBUG_LOG_NORMAL
                    Debug.Log(message);
#endif
                    break;
                case LogCategory.Procedure:
#if DEBUG_LOG_PROCEDURE
                    Debug.Log(string.Format("<color=#ffffff>{0}</color>", message));
#endif
                    break;
                case LogCategory.Resource:
#if DEBUG_LOG_RESOURCE
                    Debug.Log(string.Format("<color=#ace44a>{0}</color>", message));
#endif
                    break;
                case LogCategory.Proto:
#if DEBUG_LOG_PROTO
                    Debug.Log(message);
#endif
                    break;
            }
        }

        public static void LogError(string message, params object[] args)
        {
#if DEBUG_LOG_ERROR
            Debug.LogError(args.Length == 0?message:string.Format(message,args));
#endif
        }
        #endregion
    }
}