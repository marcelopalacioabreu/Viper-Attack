﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour 
{
	[Tooltip ("Number of minutes per second that pass, try 60")]
	public float minsPS;
		
	// Update is called once per frame
	void Update () 
	{
		float angleThisFrame = Time.deltaTime / 360 * minsPS;
		transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
