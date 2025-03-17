using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int Speed;
    [SerializeField] private int JumpPower;
    void Start()
    {
        //PlayerPrefs.SetInt("JumpKey",308);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerManager.instance.PlayerRigid.linearVelocityX = Speed;
            //transform.Translate(Speed*Time.deltaTime, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            PlayerManager.instance.PlayerRigid.linearVelocityX = 0;
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerManager.instance.PlayerRigid.linearVelocityX = -Speed;
            //transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            PlayerManager.instance.PlayerRigid.linearVelocityX = 0;
        }


        if (Input.GetKey((KeyCode)PlayerPrefs.GetInt("JumpKey"))&&PlayerManager.instance.JumpTrigger){
            PlayerManager.instance.JumpTrigger = false;
            PlayerManager.instance.PlayerRigid.AddForce(Vector2.up*JumpPower);
        }
    }
}
