using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private GameObject _coint;
    [SerializeField] private GameObject _player;
    private Transform[] _points;
    void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _points.Length; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
            CreateCoin(_points[i].transform);
        }
    }

    private void CreateCoin(Transform transform)
    {
        Instantiate(_coint, transform.position, Quaternion.identity);
    }
}
