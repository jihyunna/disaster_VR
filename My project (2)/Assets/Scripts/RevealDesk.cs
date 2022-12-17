using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class RevealDesk : MonoBehaviour
{
    public Transform Player;
    public Transform Desk_Plane;
    Vector3 target = new Vector3(-21f, 16f, 4f);
    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("책상 탈출");
        Vector3 velo = Vector3.zero;
        Player.transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        // MainCamera.transform.Translate(new Vector3(9.0f, 3.0f, 33.0f));
    }
}
