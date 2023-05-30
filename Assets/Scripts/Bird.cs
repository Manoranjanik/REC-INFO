using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public Text scoreText;
    public float score;
    private Rigidbody2D rb;
    public float jumpforce;

    
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.X))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pipe")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void UpdateScore()
    {
        score = score+1;
        scoreText.text = score.ToString();
    }
}
