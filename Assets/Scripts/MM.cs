using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("GES");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
