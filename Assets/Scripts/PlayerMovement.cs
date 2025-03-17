using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.SetInt("JumpKey",308);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerManager.instance.PlayerRigid.linearVelocityX = PlayerManager.instance.Speed;
            //transform.Translate(Speed*Time.deltaTime, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            PlayerManager.instance.PlayerRigid.linearVelocityX = 0;
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerManager.instance.PlayerRigid.linearVelocityX = -PlayerManager.instance.Speed;
            //transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            PlayerManager.instance.PlayerRigid.linearVelocityX = 0;
        }


        if (Input.GetKey((KeyCode)PlayerPrefs.GetInt("JumpKey"))&&PlayerManager.instance.JumpTrigger){
            PlayerManager.instance.JumpTrigger = false;
            PlayerManager.instance.PlayerRigid.linearVelocityY = PlayerManager.instance.JumpPower;
        }
    }
}
