using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heroHealth : MonoBehaviour
{
   
   public GameObject UIfx;
   public Transform bottlepos;

   int maxhp = 100;
   int currenthp;

  //  public Slider slider;
   public HealthBar healthBar;

  void Start()
   {
       currenthp = maxhp;
       healthBar.SetMaxHealth(maxhp);
   }

    // Update is called once per frame
    void Update()
    {
        if(currenthp<=0)
            Destroy(gameObject);
    }

   

    public void takeDamage(int dmg)
    {   
        currenthp-=dmg;
       healthBar.SetHealth(currenthp);
       GameObject clone = Instantiate(UIfx,bottlepos.position,Quaternion.identity);
       Destroy(clone,1f);
        Debug.Log(currenthp);
       // Debug.Log(slider.value);
    } 
}
