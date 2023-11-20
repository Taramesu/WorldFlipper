//场景管理系统
public class SceneSystem : SingletonBase<SceneSystem>
{
    private SceneBase sceneBase;
    
    /// <summary>
    /// 指定一个场景并切换至该场景，同时执行原场景的退出和新场景的进入
    /// </summary>
    /// <param name="scene"></param>
    public void SetScene(SceneBase scene)
    {
        if (scene == null)
            return;
        if (sceneBase != null)
            sceneBase.OnExit();//原场景退出
        sceneBase = scene;
        sceneBase.OnEnter();//新场景进入
    }
}
