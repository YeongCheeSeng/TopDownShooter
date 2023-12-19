using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICurrentWeapon : MonoBehaviour
{
    private Weapon _currentWeapon;

    private Transform _weapon;

    public TMP_Text RemainingBulletText;

    // Start is called before the first frame update
    void Start()
    {
        RemainingBulletText.text = "Weapon: None";
    }

    // Update is called once per frame
    void Update()
    {
        _weapon = GameObject.FindGameObjectWithTag("Weapon").transform;

        if (_weapon == null)
            return;

        _currentWeapon = _weapon.GetComponent<Weapon>();

        

        if (RemainingBulletText != null)
        { 

            RemainingBulletText.text = "Weapon: " + _currentWeapon.name;
        }
    }
}
