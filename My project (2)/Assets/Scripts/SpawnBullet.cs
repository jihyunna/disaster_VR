using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public Transform Piece_R, Piece_B;
    public Transform BulletFirePos;
    public float fireTime = 2.0f;
    public float firePassTime = 0.0f;

    int Color = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletFirePos.position = new Vector3(Random.Range(-50.0f, 50.0f), 80.0f, Random.Range(-50.0f, 50.0f));
        Color = Random.Range(0, 2);
        if (firePassTime >= fireTime)
        {
            switch (Color)
            {
                case 0:
                    Instantiate(Piece_R, BulletFirePos.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(Piece_B, BulletFirePos.position, Quaternion.identity);
                    break;
            }
            firePassTime = 0.0f;
        }
        else
        {
            firePassTime += Time.deltaTime;
        }
    }
}
