using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    public float projectileDamage;

    void Start()
    {
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EntityStats>().healthPoints -= projectileDamage;
            Destroy(gameObject);
        }
    }
}
