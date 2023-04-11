using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint; 
    public float moveSpeed = 1f; 

    private Transform target; 

    void Start()
    {
        target = startPoint;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        if (transform.position == target.position)
        {
            if (target == startPoint)
            {
                target = endPoint;
            }
            else if (target == endPoint)
            {
                target = startPoint;
            }
        }
    }
}
