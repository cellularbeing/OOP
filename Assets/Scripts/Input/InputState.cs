﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonState{
	public bool value; //if the button is pressed or not
	public float holdTime = 0; 
}

public enum Directions{
	Right = 1,         
	Left = -1          
}

public class InputState : MonoBehaviour {

	public Directions direction = Directions.Right;
	public float absVelX = 0f;
	public float absVelY = 0f;

	private Rigidbody2D body2d;
	private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState>();

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		absVelX = Mathf.Abs (body2d.velocity.x);
		absVelY = Mathf.Abs (body2d.velocity.y);
	}
	public void SetButtonValue(Buttons key, bool value){
		if(!buttonStates.ContainsKey(key))
			buttonStates.Add(key, new ButtonState());

		var state = buttonStates [key];

		if (state.value && !value) {
			//Debug.Log ("Button " + key + " released "+state.holdTime);
			state.holdTime = 0;
		} else if (state.value && value) {
			state.holdTime += Time.deltaTime;
			//Debug.Log("Button "+key+" down "+state.holdTime);
		}

		state.value = value;

	}

	public bool GetButtonValue(Buttons key){
		if (buttonStates.ContainsKey (key))
			return buttonStates [key].value;
		else
			return false;
	}

    public float GetButtonHoldTime(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
            return buttonStates[key].holdTime;
        else
            return 0;
    }
}
