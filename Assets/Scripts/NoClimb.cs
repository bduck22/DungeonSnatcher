using UnityEngine;

public class NoClimb : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            PlayerManager.instance.PlayerRigid.linearVelocityX = 0;
        }
    }
}
