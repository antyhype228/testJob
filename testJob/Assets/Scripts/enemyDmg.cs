using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDmg : MonoBehaviour
{
   public GameObject enemyDeathFX;
   private Transform enemyPos;

    void Start()
    {
        enemyPos = GetComponent<Transform>().transform;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Die()
    {
        GameObject deathFX = Instantiate(enemyDeathFX,enemyPos.position,Quaternion.identity) as GameObject;
        Destroy(deathFX,1f);
        Destroy(gameObject,.3f);
    }
}
