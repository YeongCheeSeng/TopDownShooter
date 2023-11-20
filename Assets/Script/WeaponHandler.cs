using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponHandler : Weapon
{
    public Weapon CurrentWeapon;
    public Transform GunPosition;

    //public AudioSource GunfireSound;

    public Vector2 PointerPosition { get; set; }

    protected bool _tryShoot = false;

    private void Start()
    {
        //GunfireSound = GetComponent<AudioSource>();
    }

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
            //PlayGunfireSound();
        }

    }
    /*
    public void PlayGunfireSound()
    {
        GunfireSound.Play();
    }
    */
}
