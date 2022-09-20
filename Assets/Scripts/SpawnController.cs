using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject _obstacle;
    public GameObject[] _patterns;

    public float _startTime;
    private float _timeBetweenSpawn;
    public float _decreaseTimeSpawn;
    public float _minTime;



    // Start is called before the first frame update
    void Start()
    {
        _timeBetweenSpawn = _startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(_timeBetweenSpawn < 0)
        {
            int id = Random.Range(0, _patterns.Length);
            GameObject go = Instantiate(_patterns[id], transform.position, Quaternion.identity);
            InstantiateObstacles(go);
            _timeBetweenSpawn = _startTime;
            if (_startTime < _minTime) 
            {
                _startTime -= _decreaseTimeSpawn;
            }
        }
        else
        {
            _timeBetweenSpawn -= Time.deltaTime;
        }
    }

    void InstantiateObstacles(GameObject go)
    {
        for (int i = 0; i < go.transform.childCount; i++)
        {
            Instantiate(_obstacle, go.transform.GetChild(i).position, Quaternion.identity);
        }
    }
}
