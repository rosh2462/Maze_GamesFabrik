using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public Animator animator;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("PlayAnimation");
            Debug.Log("Triggered");
        }
    }
}


