using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HomingMissile : Projectile
{
    public Transform Target;

    private float distance;

    void Update()
    {
        distance = Vector2.Distance(transform.position, Target.transform.position);
        Vector2 direction = Target.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, Target.transform.position, Speed * Time.deltaTime);     
    }
}
