using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmove : MonoBehaviour
{
    public float Ballmovementspeed;
    public float Extraballspeed;
    public float Maxballspeed;

    int hitcount = 0;
    void Start()
    {
        StartCoroutine(this.Gamestart());
    }
    public IEnumerator Gamestart(bool isstartingplayer1 = true)
    {
        this.hitcount = 0;
        yield return new WaitForSeconds(2);
        if (isstartingplayer1)
        {
            this.Startgame(new Vector2(-1, 0));
        }
        else
        {
            this.Startgame(new Vector2(1, 0));
        }
    }
    public void Startgame(Vector2 start)
    {
        start = start.normalized;
        float speed = this.Ballmovementspeed + hitcount * Extraballspeed;
        Rigidbody2D rigidbody2d = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = start * speed;

    }
    public void Increasehitcount()
    {
        if (this.hitcount * this.Extraballspeed <= this.Maxballspeed)
        {
            this.hitcount++;
        }
    }
}

