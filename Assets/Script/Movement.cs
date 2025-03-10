using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int Speed;
    [SerializeField] private int JumpPower;
    [SerializeField] private bool JumpTrigger;
    void Start()
    {
        PlayerPrefs.SetInt("JumpKey",308);
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


        if (Input.GetKeyDown((KeyCode)PlayerPrefs.GetInt("JumpKey"))&&JumpTrigger){
            JumpTrigger = false;
            PlayerManager.instance.PlayerRigid.AddForce(Vector2.up*JumpPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            JumpTrigger = true;
        }
    }
}
