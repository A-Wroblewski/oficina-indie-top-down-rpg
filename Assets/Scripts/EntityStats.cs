using UnityEngine;

public class EntityStats : MonoBehaviour
{
    public float maxHealthPoints;
    public float healthPoints;
    public float baseMoveSpeed;
    public float attackDamage;
    public float attackSpeed;

    private void Start()
    {
        healthPoints = maxHealthPoints;
    }

    private void Update()
    {
        Death();
    }

    void Death()
    {
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
