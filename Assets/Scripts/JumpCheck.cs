using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    void Start()
    {
        PlayerManager.instance.JumpTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            PlayerManager.instance.JumpTrigger = true;
        }
    }
}
