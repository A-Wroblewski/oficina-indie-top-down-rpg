using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectile;

    EntityStats entityStats;

    float cooldown;
    bool canAttack;

    void Start()
    {
        entityStats = gameObject.GetComponent<EntityStats>();
        canAttack = true;
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && canAttack == true)
        {
            GameObject projectileInstance = Instantiate(projectile, transform.position, Quaternion.identity);

            projectileInstance.GetComponent<ProjectileDamage>().projectileDamage = entityStats.attackDamage;

            Vector2 projectileDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

            projectileDirection.Normalize();

            projectileInstance.GetComponent<Rigidbody2D>().AddForce(projectileDirection * 7.5f, ForceMode2D.Impulse);

            canAttack = false;
            cooldown = 0;
        }

        Cooldown();
    }

    void Cooldown()
    {
        if (cooldown > entityStats.attackSpeed)
        {
            canAttack = true;
        }
        else
        {
            cooldown += Time.deltaTime;
        }
    }
}
