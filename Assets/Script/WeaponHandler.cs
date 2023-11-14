using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : Weapon
{
    public Weapon CurrentWeapon;
    public Transform GunPosition;

    public Vector2 PointerPosition { get; set; }

    protected bool _tryShoot = false;

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        HandleWeapon();

        transform.right = (PointerPosition - (Vector2)transform.position).normalized;

    }

    protected virtual void HandleInput()
    {

    }

    protected virtual void HandleWeapon()
    {
        if (CurrentWeapon == null)
            return;

        CurrentWeapon.transform.position = GunPosition.position;
        CurrentWeapon.transform.rotation = GunPosition.rotation;

        if (_tryShoot)
        {
            CurrentWeapon.Shoot();
        }
    }

    public void EquipWeapon(Weapon weapon)
    {
        if(weapon == null) 
            return; 
        
        CurrentWeapon = weapon;
    }
}
