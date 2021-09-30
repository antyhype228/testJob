using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 15f;

    private float timeBtwShots;
    public float startTimeBtwShots;

    Transform target;
    NavMeshAgent agent;

    public GameObject bullet;
    public GameObject hitVfx;

    private enemyDmg enemyDamage;
    public heroHealth heroHitPoints;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;//PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();

        enemyDamage = GetComponent<enemyDmg>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

            if(distance <= lookRadius)
            {
                agent.SetDestination(target.position);
            }
           
            if(distance <= agent.stoppingDistance)
            {
                FaceTarget();
                Debug.Log("dist<stopDist");

            }
            if(distance <= 2)
            {
              
                agent.Stop();
                enemyDamage.Die();
                heroHitPoints.takeDamage(1);
              

            } 


        // Shooting
        if(timeBtwShots <= 0)
        {
           
            timeBtwShots =  startTimeBtwShots;
           // Debug.Log("TimetoShoot");

           
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
        


    } 
     void OnCollisionEnter(Collision  co)
    {
      // agent.Stop();
           Debug.Log("STOP!!!");
               
        ContactPoint contact = co.contacts [0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;

        Instantiate(bullet,transform.position, rot);
       /* if(hitVfx!=null)
        {
            var hitEffect = Instantiate(hitVfx, pos,  rot);
            var psHit = hitEffect.GetComponent<ParticleSystem>();
            if(psHit!=null)
                Destroy(hitEffect,psHit.main.duration);
            else
            {
                var psChild = hitEffect.transform.GetChild(0).GetComponent<ParticleSystem>();
                Destroy(hitEffect, psChild.main.duration);
            }
        } */
    } 

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3( direction.x, 0 , direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
