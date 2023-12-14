using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundSpawn : MonoBehaviour
{
    public float MaxRandomSpawn = 3;
    public float MinRandomSpawn = 1;

    protected float _soundSpawnTimer = 0f;

    public GameObject[] Feedback;

    // Update is called once per frame
    void Update()
    {
        if (_soundSpawnTimer > 0)
        {
            _soundSpawnTimer -= Time.deltaTime;
            return;
        }

        _soundSpawnTimer = Random.Range(MinRandomSpawn, MaxRandomSpawn);

        if (_soundSpawnTimer <= 0)
            SpawnFeedback();
            
    }
    void SpawnFeedback()
    {
        foreach (var feedback in Feedback)
        {
            GameObject.Instantiate(feedback);
            feedback.SetActive(false);
        }
    }
}
