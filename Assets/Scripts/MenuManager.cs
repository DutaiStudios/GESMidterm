using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Canvas UI;
    public Canvas pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        UI.enabled = true;
        pausemenu.enabled = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            pause();
        }
    }

    public void pause()
    {
        Time.timeScale = 0;
        UI.enabled = false;
        pausemenu.enabled = true;
    }

    public void unpause()
    {
        UI.enabled = true;
        pausemenu.enabled = false;
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
