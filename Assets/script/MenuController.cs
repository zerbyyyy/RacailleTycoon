using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuController : MonoBehaviour
{
  
    public void ChangeScene(string _sceneName)
    {
      
      Debug.Log("1");
      SceneManager.LoadScene(_sceneName);
      Debug.Log("oui");
    }
    public void Quit()
    {
      Application.Quit();
    }
    
}
