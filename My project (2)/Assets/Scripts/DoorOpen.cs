using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private float speed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down);
        }
    }
}