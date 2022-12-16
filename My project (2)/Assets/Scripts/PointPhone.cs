using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class PointPhone : MonoBehaviour
{
    public Image LoadingBar;
    public Transform PhoneBooth;
    public Transform Manual_Phone;
    private bool IsOn;
    private float barTime = 0.0f;
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
            {
                barTime += Time.deltaTime;
            }
            LoadingBar.fillAmount = barTime / 1.0f;
            Instantiate(Manual_Phone, new Vector3(-48, 17, 25), Quaternion.Euler(0, -90, 0));
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        barTime = 0.0f;
        if (gazedAt)
        {
            Debug.Log("In");
        }
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }
    }

}
