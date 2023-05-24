using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public void Startbutton(string Start)
    {
        SceneManager.LoadScene(Start);
    }

    public void Exitbutton()
    {
        Application.Quit();
    }

    public void NextLevelButton(string NextLevel)
    {
        SceneManager.LoadScene(NextLevel);
    }

    
}
