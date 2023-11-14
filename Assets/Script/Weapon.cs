using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject Projectile;
    public Transform SpawnPos;
    public float Interval = 0.1f;
    public Cooldown AutofireShootInterval;
    

    private float _timer = 0f;
    private bool _canShoot = true;

    // Update is called once per frame
    void Update()
    {
        /*
        if (_timer < Interval)
        {
            _timer += Time.deltaTime; 
            _canShoot = false;
            return;
        }

        _timer = 0f;
        _canShoot = true;
        */

        if (AutofireShootInterval.CurrentProgress != Cooldown.Progress.Finished)
            return;

        AutofireShootInterval.CurrentProgress = Cooldown.Progress.Ready;
    }

    

    public void Shoot()
    {
        if (Projectile == null)
        {
            Debug.LogWarning("Missing Projectile prefeb");
            return;
        }

        if (SpawnPos == null)
        {
            Debug.LogWarning("Missing SpawnPosition transform");
            return;
        }

        //if (!_canShoot)
        //    return;

        if (AutofireShootInterval.CurrentProgress != Cooldown.Progress.Ready)
            return;

        GameObject bullet = GameObject.Instantiate(Projectile, SpawnPos.position, SpawnPos.rotation);

        //GameObject.Instantiate(Projectile, SpawnPos.position, SpawnPos.rotation);

        AutofireShootInterval.StartCooldown();
    }

    
}

