using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    EntityStats playerHealthPoints;

    public Slider healthPointsBar;

    void Start()
    {
        playerHealthPoints = GameObject.FindWithTag("Player").GetComponent<EntityStats>();
    }

    void Update()
    {
        PlayerHealthPoints();
    }

    void PlayerHealthPoints()
    {
        healthPointsBar.maxValue = playerHealthPoints.maxHealthPoints;
        healthPointsBar.value = playerHealthPoints.healthPoints;
    }
}
