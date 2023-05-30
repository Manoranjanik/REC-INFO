using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Balldirection : MonoBehaviour
{
    public Ballmove ballmove;
    public Score score;

    void Bounceangle(Collision2D c)
    {
        Vector3 ballposs = this.transform.position;
        Vector3 playerposs = c.gameObject.transform.position;

        float playerheight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Player1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballposs.y - playerposs.y) / playerheight;
        this.ballmove.Increasehitcount();
        this.ballmove.Startgame(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            this.Bounceangle(collision);
        }
        else if (collision.gameObject.name == "LeftWall")
        {
            score.Player2score();
        }
        else if (collision.gameObject.name == "RightWall")
        {
            score.Player1score();
        }
        
    }
}
