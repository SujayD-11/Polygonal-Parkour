using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; 
    public float followSpeed; 

    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        Vector3 newPosition = transform.position + (direction * followSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}

