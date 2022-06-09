using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherController : MonoBehaviour
{
    Animator animator;
    float coolDown = 3;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            coolDown = 3;
            animator.SetBool("Shoot", true);
        }
        else
        {
            animator.SetBool("Shoot", false);
        }
    }

    void Shoot()
    {

    }
}
