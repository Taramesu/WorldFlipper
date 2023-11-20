using UnityEngine;
using JKFrame;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[UIWindowData(typeof(LoginMenu),true,"LoginMenu",3)]
public class LoginMenu : UI_WindowBase
{
    Button startGame;
    public override void Init()
    {
        startGame = transform.Find("Title/T_1").GetComponent<Button>();
        if(startGame == null)
        {
            Debug.Log("not find button");
        }
        startGame.onClick.AddListener(() =>
        {
            SceneSystem.Instance.SetScene(new MainScene());
        });
    }

    public override void OnShow()
    {

    }

    public override void OnClose()
    {

    }
}
