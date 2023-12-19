using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp1 : PickUp
{
    public float HealAmount = 1f;

    protected override void PickedUp(Collider2D col)
    {
        Health _health = col.GetComponent<Health>();

        if (_health == null)
            return;

        _health.Heal(HealAmount);
    }
}
