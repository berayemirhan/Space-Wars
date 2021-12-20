using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Directions: MonoBehaviour
{ 
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void settings()
    {
        SceneManager.LoadScene(2);
    }
    public void quit()
    {
        Application.Quit();
        
    }
    public void mainmenü()
    {
        SceneManager.LoadScene(0);
    }
    
}
