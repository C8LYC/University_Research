using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOverScene : MonoBehaviour
{
    DataMemory dataMemory;
    bool NeedSet = false;
    int HasChange = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // called first
    void OnEnable()
    {
        //Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Start()
    {
        dataMemory = GetComponent<DataMemory>();
    }

    private void Update()
    {
        if(NeedSet)
        {
            dataMemory.NewSceneSetting();
            NeedSet = false;
        }
    }

    void OnDestroy()
    {
        //Debug.LogError("Destroy Setting");
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded : " + scene.name);
        Time.timeScale = 1f;
        NeedSet = true;
        if(HasChange == 0) // Has Change Scene
        {
            
            #region Destroy New DataMemory obj

            DataMemory[] settings = FindObjectsOfType<DataMemory>();
            
            if(settings.Length > 1)//have other setting
            {
                foreach(var set in settings)
                {
                    if(set.gameObject != gameObject)
                        Destroy(set, 0.01f);
                }              
            }

            #endregion
            

            HasChange += 1;
        }
    }
}
