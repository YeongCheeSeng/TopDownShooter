using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject[] Feedback;

    public GameObject Projectile;
    public Transform SpawnPos;
    public float Interval = 0.1f;
    public Cooldown AutofireShootInterval;

    private float _timer = 0f;
    private bool _canShoot = true;
    private bool _singleFireReset = true;

    public int BurstFireAmount = 3;
    public float BurstFireInterval = 0.1f;


    private bool _burstFiring = false;
    private float _lastShootRequestAt;


    public enum FireModes
    {
        SingleFire, // =0
        Auto,   // =1
        BurstFire   // =2
    }

    public FireModes FireMode = FireModes.Auto;

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

        switch (FireMode)
        {
            case FireModes.Auto:
                {
                    AutofireShoot();
                        break;
                }
            case FireModes.SingleFire:
                {
                    SinglefireShoot();
                        break;
                }
            case FireModes.BurstFire:
                {
                    BurstfireShoot();
                        break;
                }
        }

        //if (!_canShoot)
        //    return;

        if (AutofireShootInterval.CurrentProgress != Cooldown.Progress.Ready)
            return;

        //GameObject.Instantiate(Projectile, SpawnPos.position, SpawnPos.rotation);

        AutofireShootInterval.StartCooldown();

        SpawnFeedback();
    }

    void SpawnFeedback()
    {
        foreach (var feedback in Feedback) 
        {
             GameObject.Instantiate(feedback, SpawnPos.position, SpawnPos.rotation);
        }
    }

    void AutofireShoot()
    {
        GameObject bullet = GameObject.Instantiate(Projectile, SpawnPos.position, SpawnPos.rotation);
    }

    void SinglefireShoot()
    {
        
    }

    void BurstfireShoot()
    {
        if (!_canShoot)
            return;

        if (_burstFiring)
            return;

        if (_singleFireReset)
            return;

        if (AutofireShootInterval.CurrentProgress != Cooldown.Progress.Ready)
            return;

        //StartCoroutine("BurstfireCo");
        StartCoroutine(BurstfireCo(1f));
    }

    IEnumerator BurstfireCo(float time = 3f)
    {
        _burstFiring = true;
        _singleFireReset = false;

        if (Time.time - _lastShootRequestAt < BurstFireInterval)
        {
            yield break;
        }

        int remainingShots = BurstFireAmount;

        while (remainingShots > 0)
        {
            GameObject bullet = GameObject.Instantiate(Projectile, SpawnPos.position, SpawnPos.rotation);
            SpawnFeedback();
            _lastShootRequestAt = Time.time;

            remainingShots--;
            yield return WaitFor(BurstFireInterval);
        }

        Debug.Log("start corutine");

        /*
        while (time > 0)
        {
            time -= Time.deltaTime;
            Debug.Log(time + " remaining");
            yield return null;
        }
        */

        Debug.Log("ended");

        _burstFiring = false;
        AutofireShootInterval.StartCooldown();
    }

    IEnumerator WaitFor(float seconds)
    {
        for(float timer = 0f; timer < seconds; timer += Time.deltaTime) 
        {
            yield return null;
        }
    }

    public void StopShoot()
    {
        _singleFireReset = true;
    }
}

