using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("isRun", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("isRun", true);
        }
        else
        {
            _animator.SetBool("isRun", false);
        }
    }
}
