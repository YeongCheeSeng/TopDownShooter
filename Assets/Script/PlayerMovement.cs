using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    protected override void HandleInput()
    {
        _inputDirection = new Vector2(x: Input.GetAxis("Horizontal"), y: Input.GetAxis("Vertical"));
        Debug.Log("Player Input Detected");
    }
}
