using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public delegate void HitEvent(GameObject source);
    public HitEvent OnHit;

    public delegate void ResetEvent();
    public ResetEvent OnHitReset;

    public float CurrentHealth
    {
        get { return _currentHealth; }
    }

    public float MaxHealth = 3f;

    public Cooldown Invulnerable;

    private float _currentHealth = 3f;
    private bool _canDamage = true;


    // Update is called once per frame
    private void Update()
    {
        ResetInvulnerable();
    }

    private void ResetInvulnerable()
    {
        if (_canDamage)
            return;

        if (Invulnerable.IsOnCooldown && _canDamage == false)
            return;

        _canDamage = true;
        OnHitReset?.Invoke();
    }

    public void Damage(float damage, GameObject source)
    {
        if (!_canDamage)
            return;

        _currentHealth -= damage;

        if (_currentHealth <= 0f)
        {
            _currentHealth = 0f;
            Debug.Log("You Lose");
            Die();
        }

        Invulnerable.StartCooldown();
        _canDamage = false;

        OnHit?.Invoke(source);
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
