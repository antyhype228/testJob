using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myAnim : MonoBehaviour
{
  
    private float a;
    // Start is called before the first frame update
    void Start()
    {
      //  transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position.y = Mathf.Sin(Time.deltaTime);
       Transform ThisTransform = GetComponent<Transform>();

    //Add 1 to x axis position
a = Mathf.Sin(Time.time*5)/100;
    ThisTransform.position += new Vector3(0f,a,0f);
   // ThisTransform.rotation += new Vector3(0f,Mathf.Cos(Time.time)/100,0f);
    }
}
