using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Vector3 PositionOffset = Vector3.zero;
    public float LerpSpeed = 5f;

    protected Vector2 targetPos = Vector2.zero;
    protected Vector2 _initalOffset = Vector2.zero;
    
    private PlayerWeaponHandler _playerWeaponHandler;

    // Start is called before the first frame update
    void Start()
    {
        _playerWeaponHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerWeaponHandler>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_playerWeaponHandler == null)
            return;

        targetPos = Vector2.Lerp(targetPos, _playerWeaponHandler.AimPosition(), Time.deltaTime * LerpSpeed);    

        transform.position = new Vector3 (targetPos.x, targetPos.y, PositionOffset.z);
    }
}
