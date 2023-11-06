using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HomingMissile : Movement
{
    public Transform Target;
    public float LifeTime = 1f;
    private float _timer = 0f;


    protected override void HandleInput()
    {
        if (Target == null)
            Target = GameObject.FindWithTag("Enemy").transform;

        if (Target == null)
            return;

        _inputDirection = (Target.position - transform.position).normalized;

        if (_timer < LifeTime)
        {
            _timer += Time.deltaTime;
            return;
        }

        Die();
    }

    protected void Die()
    {
        Destroy(gameObject);
    }
}
