using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// All UI Event func will in this class
/// </summary>
public class UIEventManager : MonoBehaviour
{
    #region Var



    #endregion

    #region Function

    /// <summary>
    /// use to go to another scene , will pass through "loading scene"
    /// </summary>
    /// <param name="NewSceneName">the name of scene wanted to go</param>
    public void GoToScene(string NewSceneName)
    {
        GameObject.Find("DataMemory").GetComponent<DataMemory>().SetScene(NewSceneName);
        SceneManager.LoadScene("LoadingScene");
    }

    /// <summary>
    /// Quit Game
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    #endregion
}
