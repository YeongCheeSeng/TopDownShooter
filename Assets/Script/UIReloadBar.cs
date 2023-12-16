using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIReloadBar : MonoBehaviour
{
    public Image Reloadbar;

    private RectTransform _reticle;

    private Weapon _currentBullet;

    // Start is called before the first frame update
    void Start()
    {
        _reticle = GetComponent<RectTransform>();

        _currentBullet = _reticle.GetComponent<Weapon>();
    }


    // Update is called once per frame
    void Update()
    {
        if (_reticle == null)
        {
            Reloadbar.fillAmount = 0;
            return;
        }

        _reticle.position = Input.mousePosition;

        if (Cursor.visible)
            Cursor.visible = false;

        if (Cursor.visible == false)
        {
            if (Input.GetKey(KeyCode.Space))
                Cursor.visible = true;
        }

        float fillAmount =-  _currentBullet.CurrentBulletCount;

        Reloadbar.fillAmount = fillAmount;
        Debug.Log("bullet = " + _currentBullet.CurrentBulletCount);

    }
}
