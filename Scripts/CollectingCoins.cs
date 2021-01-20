using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectingCoins : MonoBehaviour
{
    [SerializeField] private UnityEvent _unityEvent;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Coin>(out Coin coin))
        {
            Destroy(collision.gameObject);
            _unityEvent?.Invoke();
        }
    }
}
