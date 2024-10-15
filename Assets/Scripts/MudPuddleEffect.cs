using UnityEngine;

public class MudPuddleEffect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerMovement>().entityStats.baseMoveSpeed /= 2;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerMovement>().entityStats.baseMoveSpeed *= 2;
    }
}
