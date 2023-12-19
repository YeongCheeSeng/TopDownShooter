using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Health health;

    private void Update()
    {
        PlayerDeath();
    }

    private void PlayerDeath()
    {  
        if (health.CurrentHealth <= 0f)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
