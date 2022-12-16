using UnityEngine;

public class clickDoor : MonoBehaviour
{
    private float speed = 3f;

    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.forward);
        }
    }
}