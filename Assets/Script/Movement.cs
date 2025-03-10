using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int Speed;
    [SerializeField] private int JumpPower;
    void Start()
    {
        PlayerPrefs.SetInt("JumpKey",308);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Speed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown((KeyCode)PlayerPrefs.GetInt("JumpKey"))){
            PlayerManager.instance.PlayerRigid.AddForce(Vector2.up*JumpPower);
        }
    }
}
