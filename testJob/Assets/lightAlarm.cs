using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightAlarm : MonoBehaviour
{
    Light light;
    float  rnd;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        rnd  = Random.Range(-10f,10);
            if(rnd>9.5)
            {
                light.enabled = true;
                Invoke("Delay",.25f);
            }
        
    }
    void Delay()
    {
        light.enabled = false;
    }
}
