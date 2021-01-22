using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    private float _startPoint;
    private float _endPoint;
    private float _distance;
    private float _speed;
    private void Start()
    {
        _distance = Random.Range(1, 1.5f);
        _startPoint = transform.position.x;
        _endPoint = transform.position.x + _distance;
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0,0);
        if(transform.position.x > _endPoint)
        {
            _speed = -_speed;
        }
        if(transform.position.x < _startPoint)
        {
            _speed = +_speed + Random.Range(1f, 2f);
        }
    }
}
