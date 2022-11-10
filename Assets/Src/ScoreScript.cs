using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private static int _points;
    private TextMeshProUGUI _txt;
    // Start is called before the first frame update
    void Start()
    {
        _txt = GetComponent<TextMeshProUGUI>();
        _points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _txt.text = _points.ToString();
    }

    public static void AddPoint()
    {
        _points++;
    }

    public static int GetScore()
    {
        return _points;
    }
}
