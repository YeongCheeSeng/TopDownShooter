using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : Movement
{
    public Animator _animator;

    protected override void HandleInput()
    {
        _inputDirection = new Vector2(x: Input.GetAxis("Horizontal"), y: Input.GetAxis("Vertical"));

        if (_inputDirection != null )
        _animator.SetFloat("Speed", 1);

        _animator.SetFloat("Speed", 0);
        Debug.Log("Player Input Detected");
    }
}
