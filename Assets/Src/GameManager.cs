using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _insCanvas;
    [SerializeField] private GameObject _gameoverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        _insCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        _gameoverCanvas.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
