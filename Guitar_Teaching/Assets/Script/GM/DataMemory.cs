using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMemory : MonoBehaviour
{
    public float Volume = 0.3f;
    public float mouseSensitivity = 1f;
    public string NextScene = "MainMenu";

    public void NewSceneSetting()
    {
        GameObject CurrentSetting = GameObject.Find("Setting");
        VolumnController volumnController = CurrentSetting.GetComponent<VolumnController>();
        MouseSensitivity mouseSensitivity = CurrentSetting.GetComponent<MouseSensitivity>();
        
        volumnController.SetVolObj(this);
        mouseSensitivity.SetStartMouseSensitivity(this);

        if(CurrentSetting.GetComponent<ChangeSceneController>() != null)
        {
            CurrentSetting.GetComponent<ChangeSceneController>().SetNextScene(NextScene);
        }

    }

    public void SetScene(string NewScene)
    {
        NextScene = NewScene;
    }
}
