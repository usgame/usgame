//===================================================
//作    者：zhouzelong
//博    客：http://zhouzelong.cnblogs.com
//创建时间：2020-06-26 14:01:29
//备    注：
//===================================================

namespace USGame
{
    /// <summary>
    /// Update方法接口，只有需要Update方法的组件才继承这个接口
    /// 继承了此接口需要强制要求将OnUpdate方法注入GameEntry中的全局m_UpdateComponentList中统一管理
    /// 注入方法为：继承了框架BaseComponent类之后，在重写的OnAwake方法中加入GameEntry.RegisterUpdateComponent(this);
    /// 在销毁时，注意要移除从GameEntry的m_UpdateComponentList中移除，移除代码为：GameEntry.RemoveUpdateComponent(this);
    /// </summary>
    public interface IUpdateComponent
    {
        int InstanceID { get; }

        void OnUpdate();
    }
}