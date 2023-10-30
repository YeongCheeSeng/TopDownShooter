using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Weapon;

public class PlayerWeaponHandler : WeaponHandler
{
    public FireModes _mode;

    public enum FireModes
    {
        SingleFire, // =0
        AutoFire,   // =1
        BurstFire   // =2
    }

    protected override void HandleInput()
    {
        base.HandleInput();

        if (_mode == FireModes.SingleFire)
        {
            if (Input.GetButtonDown("Fire1"))
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
