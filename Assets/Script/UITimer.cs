using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class UITimer : MonoBehaviour
{
    public float Timer = 60f;
    private int IntTimer;

    public TMP_Text TimeLeftText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerCoundDown();
    }

    void TimerCoundDown()
    {
        Timer -= Time.deltaTime;
        IntTimer = Convert.ToInt32(Timer);
        TimeLeftText.text = "Survival time: " + IntTimer.ToString();

        if (IntTimer <= 0)
        {
            Debug.Log("Time up");
        }
    }
}
