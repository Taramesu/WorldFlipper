using JKFrame;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if(currentScene.name == "LoginScene")
        {
            UISystem.Show<LoginMenu>();
        }
        else
        {
            Debug.Log("not loginScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UISystem.Close<LoginMenu>();
        }
    }
}
