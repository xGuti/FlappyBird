using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float _spawnHeight = 2f;
    public GameObject _pipePrefab;

    private static float _timeToSpawn = 5f;
    private float _timer = 0f;
    
    void FixedUpdate()
    {
        //spawning
        if (_timer >= _timeToSpawn)
        {
            _timer = 0;
            GameObject newPipe = Instantiate(_pipePrefab);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-_spawnHeight, _spawnHeight) + 1, 0);
            Destroy(newPipe, 10f);
        }

        _timer += Time.deltaTime;
    }

    public static void ReduceSpawningTime(float value)
    {
        _timeToSpawn -= value;
    }
}
