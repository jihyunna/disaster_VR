using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]

public class ManualPointerEvent : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public Transform Interphone;
    public Transform Manual;

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
            Instantiate(Manual, new Vector3(20, 72, -49), Quaternion.Euler(0, 180.0f, 0));
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
