using Unity.VisualScripting;
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
    public float Speed;
    public float JumpPower;
    public bool JumpTrigger;
    public bool Invin;
    public float InvinTime;
    

    public void HitAndInvin()
    {
        Invin = true;
        Invoke("InvinFalse", InvinTime);
    }
    void InvinFalse()
    {
        Invin = false;
    }
}
