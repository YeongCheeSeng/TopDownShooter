using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject Weapon;

    public GameObject[] PickUpFeedbacks;

    public LayerMask TargetLayerMask;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(!((TargetLayerMask.value & ( 1 << col.gameObject.layer)) > 0))
                return;

        WeaponHandler weaponHandler = GetComponent<WeaponHandler>();

        if (weaponHandler == null)
            return;

        weaponHandler.EquipWeapon(Weapon);

        foreach (var feedback in PickUpFeedbacks)
        {
            GameObject.Instantiate(feedback, transform.position, transform.rotation);
        }

        Destroy(gameObject);
    }
}
