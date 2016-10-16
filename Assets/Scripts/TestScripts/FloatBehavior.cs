using UnityEngine;
using System;
using System.Collections;

public class FloatBehavior : MonoBehaviour
{
	float originalY;

	public float floatStrength = 1f; // You can change this in the Unity Editor to 
	// change the range of y positions that are possible.
	public float floatSpeed = 1f;

	void Start()
	{
		this.originalY = this.transform.position.y;
	}

	void Update()
	{
		transform.position = new Vector3(transform.position.x,
			originalY + ((float)Math.Sin(Time.time * floatSpeed) * floatStrength),
			transform.position.z);

		//transform.Translate(0, ((float)Math.Sin(Time.time * floatSpeed) * floatStrength), 0, Space.World);
	}
}
