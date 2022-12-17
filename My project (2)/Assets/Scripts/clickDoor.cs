using UnityEngine;

public class clickDoor : MonoBehaviour
{
    private float speed = 3f;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.forward);
        }
    }
}