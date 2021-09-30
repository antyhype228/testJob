using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroDmg : MonoBehaviour
{
    public Transform attackPoint;
    float attackRange =1f;

    public LayerMask enemyLayers;
    public Animator animator;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            animator.SetBool("isAttacked",true);
            animator.SetTrigger("att");
        }

    }

    void Attack()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange,enemyLayers);

        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<enemyDmg>().Die();
        }
    }
}
