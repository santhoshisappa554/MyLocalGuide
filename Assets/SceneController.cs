using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public static string keyword;
    

    public void Start()
    {
        Debug.Log(keyword);
        
    }
    public void Quit()
    {
        Application.Quit();
        
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void AskGoogle(string keywordName)
    {
        keyword = keywordName;
    }
    
}
