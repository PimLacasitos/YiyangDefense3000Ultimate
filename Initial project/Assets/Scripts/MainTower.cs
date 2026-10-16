using UnityEngine;

public class MainTower : MonoBehaviour
{
    public int health = 911;

    public void receiveDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
