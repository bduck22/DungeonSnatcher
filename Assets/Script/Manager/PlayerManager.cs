using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance=null;
    public Rigidbody2D PlayerRigid;
    private void Awake()
    {
        if(instance != this)
        {
            instance = this;
        }
    }
}
