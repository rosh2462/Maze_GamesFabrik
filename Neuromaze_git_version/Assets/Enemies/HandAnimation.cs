using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour
{
     
   public Animator animator;
   public Transform attackPoint;
   public float attackRange = 0.5f;
   public LayerMask enemyLayers;
   public int attackdamage = 15;

     void Update()
    {

        if (Input.GetMouseButtonDown(0))
            {
                attack();
            }
    }

    void attack()
    {
     animator.SetTrigger("PlayAnimation");

        
Collider[] hitEnemies =  Physics.OverlapSphere(attackPoint.position,attackRange, enemyLayers);
    
    foreach(Collider enemy in hitEnemies)
    {
        enemy.GetComponent<Enemy>().TakeDamage(attackdamage);   
    }

    }

void OnDrawGizmosSelected(){ 
       if(attackPoint==null)
      return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}