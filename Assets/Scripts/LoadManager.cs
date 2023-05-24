using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public string SceneName;
    private Pellet[] NoofPellets;

    public void HomeButton(string Home)
    {
        SceneManager.LoadScene(Home);
    }

    public void OnEnable()
    {

        NoofPellets = FindObjectsOfType<Pellet>();
    }

    public void Update()
    {
        foreach(Pellet Pellets in NoofPellets)
        {
            if(Pellets != null)
            {
                return;
            }
        }
        SceneManager.LoadScene(SceneName);
    }
}
