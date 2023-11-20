using UnityEngine;
using JKFrame;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[UIWindowData(typeof(LoadingPanel), true, "LoadingPanel", 3)]
public class LoadingPanel : UI_WindowBase
{
    Image progressBar;
    TMP_Text text;
    public override void Init()
    {
        progressBar = transform.Find("Progress/Progress_Bar").GetComponent<Image>();
        progressBar.fillAmount = 0;
        text = transform.Find("Progress/Progress_Text").GetComponent<TMP_Text>();
        text.text = "0.00%";
        //EventSystem.AddEventListener("EventTest", OnTest);
        EventSystem.AddEventListener<float>("UpdateLoadingSceneProgress", OnSetProgress);
    }

    public override void OnShow()
    {
        Debug.Log("Loading");
    }

    public override void OnClose()
    {
        EventSystem.RemoveEventListener<float>("UpdateLoadingSceneProgress", OnSetProgress);
    }

    protected override void RegisterEventListener()
    {
 
    }

    private void OnSetProgress(float progress)
    {
        progressBar.fillAmount += progress;
        text.text = progress * 100 + "%";
    }

    private void OnTest()
    {
        Debug.Log("EventTest_1");
    }
}
