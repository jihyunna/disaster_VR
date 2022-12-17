using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiretruckMove : MonoBehaviour
{
    public GameObject TargetPosition;
    public Transform Firetruck;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Firetruck, new Vector3(188, -60, -183), Quaternion.Euler(0, 280.0f, 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, TargetPosition.transform.position, 0.5f);
    }
}
