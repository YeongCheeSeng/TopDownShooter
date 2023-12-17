using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    public Animator animator;

    private Transform _currentWeapon;
    private Weapon weaponHandler;


    // Start is called before the first frame update
    void Start()
    {
        animator.SetInteger("Weapon", 1);
    }

    // Update is called once per frame
    void Update()
    {
        _currentWeapon = GameObject.FindGameObjectWithTag("Weapon").transform;

        if (_currentWeapon != null)
        {
            weaponHandler = _currentWeapon.GetComponent<Weapon>();
            Debug.Log("Equiping: " + weaponHandler);
            animator.SetInteger("Weapon", 1);
        }
    }
}