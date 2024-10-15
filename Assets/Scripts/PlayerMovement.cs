using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public EntityStats entityStats;

    float moveSpeed;

    void Start()
    {
        entityStats = gameObject.GetComponent<EntityStats>();
        moveSpeed = entityStats.baseMoveSpeed;
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        moveSpeed = entityStats.baseMoveSpeed;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 force = new(horizontal, vertical);

        if (force.magnitude > 1)
        {
            force = force.normalized;
        }

        gameObject.GetComponent<Rigidbody2D>().AddForce(force * (moveSpeed * Time.deltaTime));
    }
}
