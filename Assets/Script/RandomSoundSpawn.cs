using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundSpawn : MonoBehaviour
{
    public float SpawnChance = 50f;

    public GameObject[] Feedbacks;

    public GameObject Enemy;

    // Update is called once per frame
    void Start()
    {
        float rollDice = Random.Range(1, 100);

        if (rollDice > SpawnChance)
            return;

        Debug.Log(" spawn sound");
        SpawnFeedback();
    }

    void SpawnFeedback()
    {
        foreach (var feedback in Feedbacks)
        {
            Debug.Log(feedback);
            GameObject.Instantiate(feedback);
        }
    }
}
