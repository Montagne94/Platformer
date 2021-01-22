using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _force;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody2D;
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * _speed * Time.deltaTime);
            _spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate((transform.right * _speed) * -1 * Time.deltaTime);
            _spriteRenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody2D.AddForce(transform.up * _force, ForceMode2D.Impulse);
        }
    }
}
