using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIReload : MonoBehaviour
{
    private Weapon _currentBullet;

    private Transform _weapon;

    private static float TotalBullet;
    public TMP_Text RemainingBulletText;

    // Start is called before the first frame update
    void Start()
    {
        TotalBullet = 0;

        _weapon = GameObject.FindGameObjectWithTag("Weapon").transform;

        _currentBullet = _weapon.GetComponent<Weapon>();
    }

    void BulletCount()
    {
        TotalBullet = _currentBullet.CurrentBulletCount;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("bullet = " + _currentBullet.CurrentBulletCount);
        BulletCount();

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
