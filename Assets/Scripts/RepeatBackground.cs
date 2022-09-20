using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public float _speed;
    public float _length;

    Vector3 _startPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float magnitude = Mathf.Repeat(Time.time * _speed, _length);
        transform.position = _startPosition + Vector3.left * magnitude; 
    }
}
