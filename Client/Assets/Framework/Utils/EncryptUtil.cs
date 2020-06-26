//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 14:35:12
//备    注：
//===================================================
using System;
using System.IO;

namespace USGame
{
    public static class EncryptUtil
    {
        /// <summary>
        /// 获取字符串的MD5
        /// </summary>
        /// <param name="value">字符串</param>
        /// <returns></returns>
        public static string Md5(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(value));
            string strResult = BitConverter.ToString(bytResult);
            strResult = strResult.Replace("-", "");
            return strResult;
        }

        /// <summary>
        /// 获取文件的MD5
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetFileMD5(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return null;
            }
            try
            {
                FileStream file = new FileStream(filePath, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] bytResult = md5.ComputeHash(file);
                string strResult = BitConverter.ToString(bytResult);
                strResult = strResult.Replace("-", "");
                return strResult;
            }
            catch
            {
                return null;
            }
        }
    }
}