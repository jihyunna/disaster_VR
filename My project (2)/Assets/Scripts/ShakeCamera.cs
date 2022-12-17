using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    private float shakeTime;
    private float shakeIntensity;


    void Start()

    {
    }

    public void onShakeCamera(float shakeTime = 2.0f, float shakeIntensity = 2.0f)
    {
        Debug.Log("Invoke Time" + Time.time);
        this.shakeTime = shakeTime;
        this.shakeIntensity = shakeIntensity;

        StopCoroutine("ShakeByPosition");
        StartCoroutine("ShakeByPosition");
    }

    private IEnumerator ShakeByPosition()
    {
        Vector3 startPosition = transform.position;

        while (shakeTime > 0.0f)
        {
            transform.position = startPosition + Random.insideUnitSphere * shakeIntensity;

            shakeTime -= Time.deltaTime;

            yield return new WaitForSeconds(5.0f);
        }
        transform.position = startPosition;
    }

    private void Update()
    {
        Debug.Log("Start Time " + Time.time);
        Invoke("onShakeCamera", 5.0f);
        onShakeCamera(5f, 0.3f);
    }

}