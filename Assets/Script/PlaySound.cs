using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource Sound;

    // Start is called before the first frame update
    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Sound == null)
            Sound.Play();        
    }
}
