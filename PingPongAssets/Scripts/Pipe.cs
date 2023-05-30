using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * 1 * Time.deltaTime);
    }
}
