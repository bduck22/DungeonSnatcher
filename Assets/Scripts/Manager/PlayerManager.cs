using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public Rigidbody2D PlayerRigid;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
    }
    public int Hp;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerManager.instance.Hp--;
    }
}
