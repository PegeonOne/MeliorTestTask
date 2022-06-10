using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    Rigidbody rb;
    float lifeTime = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0) RemoveArrow();
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("enemy"))
        {
            RemoveArrow();
        }
    }
    void RemoveArrow()
    {
        Destroy(this.gameObject);
    }
}
