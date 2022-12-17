using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]

public class TowelPointerEvent : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public GameObject Towel;
    public GameObject TargetPosition2;


    void Start()
    {
        //IsOn = false;
        //LoadingBar.fillAmount = 0;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, TargetPosition2.transform.position, 0.5f);
        }
        /*if (IsOn)
        {
            if (barTime <= 10.0f)
                barTime += Time.deltaTime;

            LoadingBar.fillAmount = barTime / 10.0f;
            transform.position = Vector3.MoveTowards(gameObject.transform.position, TargetPosition2.transform.position, 0.5f);
        }
        */
       // transform.position = Vector3.MoveTowards(gameObject.transform.position, TargetPosition2.transform.position, 0.5f);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

    }

    /*public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        barTime = 0.0f;
        if (gazedAt)
            Debug.Log("In");
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }
    }*/
}
