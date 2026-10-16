using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform target;
    public float speed;
    public int damage = 10;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        
        transform.position += direction.normalized * speed * Time.deltaTime;

        transform.LookAt(direction);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MainTower"))
        {
            collision.gameObject.GetComponent<MainTower>().receiveDamage(damage);
            Destroy(gameObject);
        }
    }
}
