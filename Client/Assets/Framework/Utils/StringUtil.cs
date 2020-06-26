//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 14:46:32
//备    注：
//===================================================

namespace USGame
{
    /// <summary>
    /// string 扩展
    /// </summary>
    public static class StringUtil
    {
        /// <summary>
        /// 把string类型转换成int
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ToInt(this string str)
        {
            int temp;
            int.TryParse(str, out temp);
            return temp;
        }

        /// <summary>
        /// 把string类型转换成long
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static long ToLong(this string str)
        {
            long temp;
            long.TryParse(str, out temp);
            return temp;
        }

        /// <summary>
        /// 把string类型转换成float
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float ToFloat(this string str)
        {
            float temp;
            float.TryParse(str, out temp);
            return temp;
        }
    }
}