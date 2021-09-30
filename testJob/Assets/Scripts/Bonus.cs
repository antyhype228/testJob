using  System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour

{   public Animator animator;
    public GameObject fx;

  
   void OnTriggerEnter(Collider other)
   {
       scoreSystem.score += 10;
       animator.SetTrigger("dead");
       Destroy(gameObject,.5f);
      GameObject clone =  Instantiate(fx,transform.position,Quaternion.identity) as GameObject;
        Destroy(clone,1f);
      
   }
  
 
}
