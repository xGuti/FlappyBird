using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelMover : MonoBehaviour
{
    private int _direction;

    private void Start()
    {
        transform.position = new Vector3(0, 3f, 0);
        _direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.y);
        if(transform.position.y < 2.75f || transform.position.y > 3.25f)
            _direction *= -1;

        transform.position += Vector3.up * _direction * .005f;
    }
}
