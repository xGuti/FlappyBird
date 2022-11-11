using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("playbtn");
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Debug.Log("exitbtn");
        Application.Quit();
    }
}
