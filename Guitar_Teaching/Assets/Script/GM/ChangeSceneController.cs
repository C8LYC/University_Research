using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Control loading scene ProcessBar and change to target scene
/// </summary>
public class ChangeSceneController : MonoBehaviour
{
    AsyncOperation NewScene;
    public string NextSceneName = "MainMenu";
    public Image ProcessBar;
    public GameObject ReadyText;
    public GameObject StartText;
    public bool LoadNextScene = false;
    float CurrentFill = 0f;

    void OnEnable()
    {
        //Debug.Log("OnEnable called");
    }

    private void Update()
    {
        if(LoadNextScene)
        {
            NewScene = SceneManager.LoadSceneAsync(NextSceneName);
            NewScene.allowSceneActivation = false;
            StartCoroutine(Loading());
            LoadNextScene = false;
        }
    }

    #region Function

    public void SetNextScene(string NextName)
    {
        NextSceneName = NextName;
        LoadNextScene = true;
    }

    IEnumerator Loading()
    {
        while(NewScene.progress < 0.9f)
        {
            Debug.Log("NewScene.progress " + NewScene.progress);
            
            if(!ReadyText.activeSelf)
            {
                ReadyText.SetActive(true);
                StartText.SetActive(false);
            }

            if (CurrentFill < NewScene.progress)
            {
                Debug.Log("fillAmount set , CurrentFill = " + CurrentFill);
                ProcessBar.fillAmount = CurrentFill;
                CurrentFill += 0.01f;
                
            }
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Load done");
        
        if (!StartText.activeSelf)
        {
            ReadyText.SetActive(false);
            StartText.SetActive(true);
        }
        CurrentFill = 1f;
        ProcessBar.fillAmount = CurrentFill;
        yield return new WaitForSeconds(1f);
        NewScene.allowSceneActivation = true;

    }

    #endregion
}
