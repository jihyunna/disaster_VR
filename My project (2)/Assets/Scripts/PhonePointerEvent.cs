using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]

public class PhonePointerEvent : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public Transform Phone;
    public Transform Call_119;

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
            Instantiate(Call_119, new Vector3(-10, 62, -29), Quaternion.Euler(40.0f, 270.0f, 0));
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
