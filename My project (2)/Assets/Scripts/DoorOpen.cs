using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]

public class DoorOpen : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public Transform Door;

    void Start()
    {
        IsOn = false;
        LoadingBar.fillAmount = 0;
    }

    void Update()
    {
        if (IsOn)
        {
            if (barTime <= 1.0f)
                barTime += Time.deltaTime;

            LoadingBar.fillAmount = barTime / 1.0f;
            //transform.Rotate(new Vector3(0, -180, 0));
            //transform.position = new Vector3(gameObject.transform.position, TargetPosition.transform.position, 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void SetGazedAt(bool gazedAt)
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
    }

}
