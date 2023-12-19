using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Control()
    {
        SceneManager.LoadScene("Control");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void FixedUpdate()
    {
        if(Cursor.visible == false)
            Cursor.visible = true;
    }
}
