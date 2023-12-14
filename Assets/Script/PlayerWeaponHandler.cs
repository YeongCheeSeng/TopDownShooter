using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class PlayerWeaponHandler : WeaponHandler
{

    //public FireModes Mode;
    //public float SingleShot = 1f;

    public Transform AimOffset;

    protected override void HandleInput()
    {
        if (Input.GetButton("Fire1"))
        {
            _tryShoot = true;
        }
        else
        {
            _tryShoot = false;
        }
    }

    public Vector2 AimPosition()
    {
        if (CurrentWeapon == null)
            return new Vector2(transform.position.x, transform.position.y);

        return new Vector2(AimOffset.position.x, AimOffset.position.y);
    }
    
}

