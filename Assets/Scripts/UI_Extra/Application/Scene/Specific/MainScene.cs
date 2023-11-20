using JKFrame;
using UnityEngine.SceneManagement;

public class MainScene : SceneBase
{
    private static readonly string sceneName = "MainScene";
    public override void OnEnter()
    {
        if (SceneManager.GetActiveScene().name != sceneName)
        {
            GameManager.Instance.SwitchScene(sceneName);
            SceneManager.sceneLoaded += SceneLoaded;
        }
        else
        {
            //UISystem.Show<LoginMenu>();
        }
    }

    public override void OnExit()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
        UISystem.CloseAllWindow();
    }

    private void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //UISystem.Show<LoginMenu>();
    }
}
