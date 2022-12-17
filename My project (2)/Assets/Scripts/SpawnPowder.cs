using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowder : MonoBehaviour
{
	public Transform Powder;
	public Transform PowderFirePos;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			Instantiate(Powder, PowderFirePos.position, PowderFirePos.rotation);
		}
	
	}
}

