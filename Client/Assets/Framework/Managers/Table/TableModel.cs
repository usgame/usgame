//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 13:50:28
//备    注：
//===================================================
using System.Collections.Generic;

namespace USGame
{
    /// <summary>
    /// 表格模型基类，管理一张表格
    /// </summary>
    /// <typeparam name="T">表格子类类型</typeparam>
    public abstract class TableModel<T> where T : TableEntity
    {
        /// <summary>
        /// 存储表格数据
        /// </summary>
        protected List<T> m_List;

        /// <summary>
        /// id与数据映射
        /// </summary>
        protected Dictionary<int, T> m_Dic;

        /// <summary>
        /// 构造函数
        /// </summary>
        public TableModel()
        {
            m_List = new List<T>();
            m_Dic = new Dictionary<int, T>();
        }

        /// <summary>
        /// 数据表名
        /// </summary>
        public abstract string TableName { get; }

        public void LoadData()
        {

        }
    }
}