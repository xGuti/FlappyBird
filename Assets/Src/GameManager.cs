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

    public static void LevelUp()
    {
        int score = ScoreScript.GetScore();
        if (score < 25 && score % 5 == 0)
            PipeSpawner.ReduceSpawningTime(0.5f);

        if (score % 10 == 0)
            PipeMovement.AddSpeed(.1f);
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
