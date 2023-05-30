using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Playbutton : MonoBehaviour
{
	public void Play()
	{
		SceneManager.LoadScene("Game");
	}
}
