using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PipesGenerator : MonoBehaviour
{
    public GameObject pipe;
    public Vector3 pos;
    //public Vector3 pos;
  
    void Start()
    {
        StartCoroutine(Generatepipes());
       
    }

  
    void Update()
    {
        
    }
   IEnumerator Generatepipes()
   {
        while(true)
        {
            yield return new WaitForSeconds(4f);
            float randy = Random.Range(-1f, 3.5f);
            pos = new Vector3(4f, randy, 0f);
            Instantiate(pipe, pos, Quaternion.identity);
           
;        }
   }               

   
}
