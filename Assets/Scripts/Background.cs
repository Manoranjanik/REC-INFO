using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject quad;
    private Renderer rend;
    public float speed;
    //public float speed = 10;
    
    void Start()
    {
        rend = quad.GetComponent<Renderer>();
    }

   
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        rend.material.mainTextureOffset = offset;
    }
}
