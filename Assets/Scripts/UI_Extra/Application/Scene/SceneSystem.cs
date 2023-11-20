//��������ϵͳ
public class SceneSystem : SingletonBase<SceneSystem>
{
    private SceneBase sceneBase;
    
    /// <summary>
    /// ָ��һ���������л����ó�����ͬʱִ��ԭ�������˳����³����Ľ���
    /// </summary>
    /// <param name="scene"></param>
    public void SetScene(SceneBase scene)
    {
        if (scene == null)
            return;
        if (sceneBase != null)
            sceneBase.OnExit();//ԭ�����˳�
        sceneBase = scene;
        sceneBase.OnEnter();//�³�������
    }
}
