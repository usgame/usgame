//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 13:54:16
//备    注：
//===================================================

namespace USGame
{
    /// <summary>
    /// 事件ID(4位编号,前两位表示模块,后两位表示编号)
    /// </summary>
    public class SocketEventId
    {
        /// <summary>
        /// 所有表格加载完毕
        /// </summary>
        public const ushort LoadDataTableComplete = 1001;

        /// <summary>
        /// 单个表格加载完毕
        /// </summary>
        public const ushort LoadOneDataTableComplete = 1002;

        /// <summary>
        /// 加载Lua表格完毕
        /// </summary>
        public const ushort LoadLuaDataTableComplete = 1003;

        /// <summary>
        /// 加载进度条更新
        /// </summary>
        public const ushort LoadingProgressChange = 1004;

        /// <summary>
        /// 检查版本更新开始下载
        /// </summary>
        public const ushort CheckVersionBeginDownload = 1201;

        /// <summary>
        /// 检查版本更新下载中
        /// </summary>
        public const ushort CheckVersionDownloadUpdate = 1202;

        /// <summary>
        /// 检查版本更新下载完毕
        /// </summary>
        public const ushort CheckVersionDownloadComplete = 1203;
    }
}