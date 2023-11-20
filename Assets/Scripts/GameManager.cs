using JKFrame;
using System.Collections;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        //EventSystem.AddEventListener("LoadingScene",);
    }

    // Start is called before the first frame update
    void Start()
    {
        SceneSystem.Instance.SetScene(new LoginScene());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            JKFrame.EventSystem.EventTrigger("EventTest");
            Debug.Log("EventTest_0");
        }
    }

    public void SwitchScene(string sceneName)
    {
        StartCoroutine(Delay(sceneName));
    }

    private IEnumerator Delay(string sceneName) 
    {
        UISystem.Show<LoadingPanel>();
        AsyncOperation ao = SceneManager.LoadSceneAsync(sceneName);
        ao.allowSceneActivation = false;
        while (!ao.isDone) 
        {
            if (ao.progress >= 0.9f)
            {
                JKFrame.EventSystem.EventTrigger("UpdateLoadingSceneProgress", 1.0f);
                ao.allowSceneActivation = true;
            }
            else
            {
                JKFrame.EventSystem.EventTrigger("UpdateLoadingSceneProgress", ao.progress);
            }

            yield return new WaitForSeconds(1.0f);
        }
    }
}
