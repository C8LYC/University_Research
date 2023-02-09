using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// for normal scene to change to another scene
/// </summary>
public class ButtonChangeScene : MonoBehaviour
{
    #region function
    /// <summary>
    /// use to go to another scene , will pass through "loading scene"
    /// </summary>
    /// <param name="NewSceneName">the name of scene wanted to go</param>
    public void GoToScene(string NewSceneName)
    {
        GameObject.Find("DataMemory").GetComponent<DataMemory>().SetScene(NewSceneName);
        SceneManager.LoadScene("LoadingScene");
    }

    #endregion
}
