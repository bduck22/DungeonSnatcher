using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerManager.instance.transform.position+new Vector3(0,2.5f,-10), 4.25f* Time.deltaTime);
    }
}
