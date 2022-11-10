using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float _spawnHeight = 2f;
    private float _timeToSpawn = 3f;
    public GameObject _pipePrefab;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_timeToSpawn <= 0)
        {
            _timeToSpawn = 3;
            GameObject newPipe = Instantiate(_pipePrefab);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-_spawnHeight, _spawnHeight) + 1, 0);
            Destroy(newPipe, 10f);
        }
        _timeToSpawn -= Time.deltaTime;
    }
}
