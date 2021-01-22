using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRestart : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _spawn;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            _player.transform.position = _spawn.transform.position;
        }
    }
}
