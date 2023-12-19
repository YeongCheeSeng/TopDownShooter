using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class HealthPickUp : PickUp
{
    public float HealAmount = 1f;

    protected override void PickedUp(Collider2D col)
    {
        Health _health = col.GetComponent<Health>();

        if (_health.CurrentHealth == _health.MaxHealth)
            return;


        if (_health == null)
            return;

        _health.Heal(HealAmount);
    }
}
