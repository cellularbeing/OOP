using UnityEngine;
using System;
using System.Collections;

public class FloatBehavior : MonoBehaviour
{
	float originalY;

	public float floatStrength = 1; // You can change this in the Unity Editor to 
	// change the range of y positions that are possible.
	public float floatSpeed = 1;

	void Start()
	{
		this.originalY = this.transform.position.y;
	}

	void Update()
	{
		transform.position = new Vector3(transform.position.x,
			originalY + ((float)Math.Sin(Time.time * floatSpeed) * floatStrength),
			transform.position.z);
	}
}
