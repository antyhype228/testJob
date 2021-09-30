using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class staticEnemyDmg : MonoBehaviour
{
  // var variableForPrefab = Resources.Load("electroBall",GameObject) as GameObject;
    //public Transform firePoint;
    public GameObject sphere;
    public GameObject dots;
    public GameObject psLightings;

    private float attackRange = 4f;
    public LayerMask playerLayer;
    int enemyDamage = 5;

    private float timeBtwShots;
    public float startTimeBtwShots;

    Transform target;
    

  Light light;
    

  //  public GameObject bullet;
  

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
       // it = GetComponent<Transform>().transform;
       light = GetComponent<Light>();
       
       
    }

    // Update is called once per frame
    void Update()
    {
       
        // Shooting
        if(timeBtwShots <= 0)
        {
            Attack();
      
           GameObject clone = Instantiate(sphere,transform.position, Quaternion.identity) as GameObject;
           GameObject clone2 = Instantiate(psLightings,transform.position, Quaternion.identity) as GameObject;
           GameObject clone3 = Instantiate(dots,transform.position, Quaternion.identity);

            timeBtwShots =  startTimeBtwShots;

            Destroy(clone,1f);
            Destroy(clone2,1f);
            Destroy(clone3,1f);

             
           light.enabled = true;
           Invoke("TurningLight",.5f);
           
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
            
            
           
        }
       
        


    } 
  void Attack()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, attackRange,playerLayer);
       
        foreach(Collider hero in hit)
        {
            hero.GetComponent<heroHealth>().takeDamage(enemyDamage);

        }
    }
    void TurningLight()
    {
      light.enabled = false;
      Debug.Log("Works!!");
    }

    
   

   

   
}
