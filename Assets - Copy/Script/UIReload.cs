using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIReload : MonoBehaviour
{
    private Weapon _currentWeapon;

    private Transform _weapon;

    private float TotalBullet;
    public TMP_Text RemainingBulletText;

    // Start is called before the first frame update
    void Start()
    {
        TotalBullet = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _weapon = GameObject.FindGameObjectWithTag("Weapon").transform;

        if (_weapon == null)
            return;

        _currentWeapon = _weapon.GetComponent<Weapon>();

        TotalBullet = _currentWeapon.CurrentBulletCount;

        if (_currentWeapon == null)
        {
            Debug.Log("_currentBullet is missing");
            return;
        }

        if (RemainingBulletText != null)
        {
            RemainingBulletText.text = "Bullet: " + TotalBullet.ToString();
        }

        if (TotalBullet == 0)
        {
            RemainingBulletText.text = "Bullet: Reloading";
        }
    }

}
