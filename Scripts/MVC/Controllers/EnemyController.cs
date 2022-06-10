using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector3.right * 4.3f, Time.deltaTime * 2);
    }
}
