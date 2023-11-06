using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;
using static Weapon;

public class PlayerWeaponHandler : WeaponHandler
{
    public FireModes Mode;
    public float SingleShot = 1f;

    public enum FireModes
    {
        SingleFire, // =0
        AutoFire,   // =1
        BurstFire   // =2
    }

    protected override void HandleInput()
    {
        if (Mode == FireModes.SingleFire)
        {
            Debug.Log("Single Fire Mode");
            if (Input.GetButtonDown("Fire1"))
            {
                _tryShoot = false;
                Shoot();
            }

            if (Input.GetButtonUp("Fire1"))
            {
                _tryShoot = false;
            }

        }

        if (Mode == FireModes.AutoFire)
        {
            Debug.Log("Auto Fire Mode");
            if (Input.GetButton("Fire1"))
            {
                _tryShoot = true;
            }

            if (Input.GetButtonUp("Fire1"))
            {
                _tryShoot = false;
            }
        }

        if (Mode == FireModes.BurstFire)
        {
            Debug.Log("Burst Fire Mode");
            if (Input.GetButton("Fire1"))
            {
                _tryShoot = true;
            }

            if (Input.GetButtonUp("Fire1"))
            {
                _tryShoot = false;
            }
        }

    }
}

