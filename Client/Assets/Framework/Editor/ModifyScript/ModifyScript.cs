//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-04 00:19:08
//备    注：创建脚本时，自动生成代码注释
//===================================================
using System;
using System.IO;
using UnityEngine;

public class InitScript : UnityEditor.AssetModificationProcessor
{
    private static void OnWillCreateAsset(string path)
    {
        // 是否为 C# 文件
        string destFilePath = path.Replace(".meta", "");
        if (!destFilePath.EndsWith(".cs")) { return; }

        // 模板是否存在
        string templatePath = "Assets/Framework/Editor/ModifyScript/ModifyTemplate.cs";
        if (File.Exists(templatePath))
        {
            // 读取模板
            string strContent = File.ReadAllText(templatePath);

            // 修改模板
            string destFileName = Path.GetFileName(destFilePath).Replace(".cs", "");
            strContent = strContent.Replace("#CreateTime#", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            strContent = strContent.Replace("ModifyTemplate", destFileName);

            // 写入文件
            File.WriteAllText(destFilePath, strContent);
        }
    }
}
