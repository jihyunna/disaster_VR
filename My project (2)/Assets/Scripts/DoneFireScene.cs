using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]

public class DoneFireScene : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public Transform FireTruck;

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
            SceneManager.LoadScene("Restart");
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
