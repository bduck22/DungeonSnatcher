using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Attack;
    void Start()
    {
        //PlayerPrefs.SetInt("Attack", 122);
    }
    void Update()
    {
        if (Input.GetKeyDown((KeyCode)PlayerPrefs.GetInt("Attack")))
        {
            Attack.SetActive(true);
        }
        else if (Input.GetKeyUp((KeyCode)PlayerPrefs.GetInt("Attack")))
        {
            Attack.SetActive(false);
        }
    }
}
