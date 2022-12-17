using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFire : MonoBehaviour
{
    public int HP = 20;
    public Transform Extinguisher;
    public Transform Manual;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "POWDER")
        {
            HP--;
            if (HP <= 0)
            {
                //Destroy(gameObject);
                Instantiate(Manual, new Vector3(40, 65, -20), Quaternion.Euler(0, 90.0f, 0));

            }
        }
    }
}
