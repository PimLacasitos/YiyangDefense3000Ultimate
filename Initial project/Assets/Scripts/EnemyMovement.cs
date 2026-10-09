using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform target;
    public float speed;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        
        transform.position += direction.normalized * speed * Time.deltaTime;

        transform.LookAt(direction);
    }
}
