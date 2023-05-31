using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetect : MonoBehaviour
{
    private Bird bird; 
    
    void Start()
    {
        bird = GameObject.Find("bird").GetComponent<Bird>();
    }

   
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bird.UpdateScore();
        }
    }
}
