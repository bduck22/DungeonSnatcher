using UnityEditor.Experimental.GraphView;
using UnityEngine;

public enum EnemyType
{
    HeatRange,
    ShortRange,
    LongRange
}
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] int range;
    [SerializeField]bool left;
    [SerializeField]bool right;
    [SerializeField]GameObject target;
    void Start()
    {
        left = false;
        right = false;
        Invoke("Move", 5);
    }
    
    void Update()
    {
        if (Vector2.Distance(PlayerManager.instance.transform.position, transform.position) < range && !target)
        {
            target = PlayerManager.instance.gameObject;
        }
        else
        {
            if (target)
            {
                if (target.transform.position.x > transform.position.x)
                {
                    left = false;
                    right = true;
                }
                else
                {
                    left = true;
                    right = false;
                }
                if (Vector2.Distance(target.transform.position, transform.position) > range)
                {
                    target = null;
                }
            }
        }
        RaycastHit2D GroundRay = Physics2D.Raycast(transform.position + new Vector3(-1 + (right ? 2 : 0), -1, 0), Vector3.down, 1);
        if ((!GroundRay && (right || left))||((GroundRay && GroundRay.transform.gameObject.layer != 3)))
        {
            left = false;
            right = false;
        }
        RaycastHit2D WallRay = Physics2D.Raycast(transform.position + new Vector3(-0.6f + (right ? 1.2f : 0), 0, 0), (right ? Vector3.right : Vector3.left), 1);
        if (WallRay && (right || left) && WallRay.transform.gameObject.layer == 3)
        {
            left = false;
            right = false;
        }
        if (left)
        {
            transform.Translate(-3 * Time.deltaTime, 0, 0);
        }
        if (right)
        {
            transform.Translate(3 * Time.deltaTime, 0, 0);
        }
    }
    void Move()
    {
        int moveType = Random.Range(-1, 2);
        if (moveType == 0)
        {
            left = true;
            right = false;
        }
        else if(moveType == 1)
        {
            left = false;
            right = true;
        }else
        {
            left = false;
            right = false;
        }
        Invoke("Move", 5);
    }
}
