using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powder : MonoBehaviour
{
	private float powderSpeed = 1000.0f;
	private Transform thisTransform;
	// Use this for initialization
	void Start()
	{
		thisTransform = GetComponent<Transform>();
		FirePowder();
	}

	void FirePowder()
	{
		GetComponent<Rigidbody>().AddForce(thisTransform.forward * powderSpeed);
	}
}

