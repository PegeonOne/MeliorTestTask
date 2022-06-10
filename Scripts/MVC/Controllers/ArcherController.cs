using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherController : MonoBehaviour
{
    Animator animator;
    float coolDown = 3;
    [SerializeField] GameObject Arrow;
    [SerializeField] Transform arrowStartPoint;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            coolDown = Random.Range(1, 3);
            animator.SetBool("Shoot", true);
            Shoot();
        }
        else
        {
            animator.SetBool("Shoot", false);
        }
    }

    void Shoot()
    {
        GameObject arrow = Instantiate(Arrow, arrowStartPoint.position, Quaternion.identity);
        Rigidbody arrowRb = arrow.GetComponent<Rigidbody>();
        Vector3 shootDir = new Vector3(-1, Random.value, 0);
        float forceMult = Random.Range(5, 7);
        arrowRb.AddForce(shootDir * forceMult, ForceMode.Impulse);
    }
}
