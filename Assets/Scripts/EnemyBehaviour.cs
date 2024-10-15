using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public EntityStats entityStats;

    GameObject player;

    void Start()
    {
        entityStats = gameObject.GetComponent<EntityStats>();
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, entityStats.baseMoveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<EntityStats>().healthPoints -= entityStats.attackDamage;
            entityStats.healthPoints -= entityStats.maxHealthPoints;
        }
    }
}
