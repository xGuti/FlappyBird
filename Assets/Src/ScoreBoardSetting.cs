using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardSetting : MonoBehaviour
{
    [SerializeField] Sprite[] _coinSprites;
    private int _score;
    private SpriteRenderer _coinImage;
    private TextMeshProUGUI _scoreText;

    void Awake()
    {
        //load data
        _coinImage = GameObject.Find("CoinImage").GetComponent<SpriteRenderer>();
        _scoreText = GameObject.Find("FinalScore").GetComponent<TextMeshProUGUI>();
        _score = ScoreScript.GetScore();

        //set medal
        switch (_score)
        {
            case >= 25 and < 50:
                _coinImage.sprite = _coinSprites[1];
                break;
            case >= 50 and < 200:
                _coinImage.sprite = _coinSprites[2];
                break;
            case >=200 and < 500:
                _coinImage.sprite = _coinSprites[3];
                break;
            case >= 1000:
                _coinImage.sprite = _coinSprites[4];
                break;
            default:
                _coinImage.sprite = _coinSprites[0];
                break;
        }

        _scoreText.text = _score.ToString();
    }

}
