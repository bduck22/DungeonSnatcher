using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerStep : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>() && !PlayerManager.instance.Invin)
        {
            PlayerManager.instance.HitAndInvin();
            PlayerManager.instance.Hp--;
        }
    }
}
