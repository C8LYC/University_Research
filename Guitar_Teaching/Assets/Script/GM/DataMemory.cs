using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMemory : MonoBehaviour
{
    //public float Volume = 0.3f;
    //public float mouseSensitivity = 1f;
    public string NextScene { get; set; }

    public void NewSceneSetting()
    {
        GameObject LoadingSceneGM = GameObject.Find("LoadingSceneGM");

        if(LoadingSceneGM != null && LoadingSceneGM.GetComponent<ChangeSceneController>() != null)
        {
            LoadingSceneGM.GetComponent<ChangeSceneController>().SetNextScene(NextScene);
        }
    }

    public void SetScene(string NewScene)
    {
        NextScene = NewScene;
    }
}
