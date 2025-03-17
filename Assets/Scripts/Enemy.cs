using UnityEngine;

//public enum EnemyType
//{

//}
public class Enemy : MonoBehaviour
{
    public int Hp;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PolygonCollider2D>())
        {
            Hp--;
        }
    }
}
