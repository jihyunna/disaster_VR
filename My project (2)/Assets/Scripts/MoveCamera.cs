using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.forward * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.forward * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.forward * 2.0f * Time.deltaTime);
        }
    }
}