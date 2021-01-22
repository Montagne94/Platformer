using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimatorChange : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
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
