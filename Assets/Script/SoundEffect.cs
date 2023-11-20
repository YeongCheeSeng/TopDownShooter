using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : WeaponHandler
{
    public AudioSource _AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        _AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_AudioSource == null)
            return;

        if (_tryShoot == true)
            PlaySoundEffect();

    }

    public void PlaySoundEffect()
    {
        if (_AudioSource == null)
            _AudioSource.Play();
    }
}
