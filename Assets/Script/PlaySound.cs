using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public GameObject[] Sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sound == null)
            return;

        int randomSound = Random.Range(0, Sound.Length);

        GameObject _playSound = GameObject.Instantiate(Sound[randomSound]);
        Destroy(_playSound, 1f);
    }
}
