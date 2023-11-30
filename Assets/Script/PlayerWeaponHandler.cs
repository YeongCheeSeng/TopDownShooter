using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class PlayerWeaponHandler : WeaponHandler
{
    
    //public FireModes Mode;
    //public float SingleShot = 1f;


    protected override void HandleInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _tryShoot = true;
        }
        else
        {
            _tryShoot = false;
        }
    }
    
}

