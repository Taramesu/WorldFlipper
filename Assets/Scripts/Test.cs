using JKFrame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventSystem.AddEventListener("EventTest",OnTest);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTest()
    {
        Debug.Log("EventTest_2");
    }
}
