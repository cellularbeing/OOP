using UnityEngine;
using System.Collections;

public class SpearTrapManager : MonoBehaviour {

	Animator anim;
	[SerializeField] private float timeBetweenAttacks = 5.0f;
	[SerializeField] private float timeBeforeActivation = 0.0f;
	private float attackCountdown;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
		attackCountdown = timeBetweenAttacks + timeBeforeActivation;

	}
	
	// Update is called once per frame
	void Update () 
	{
		attackCountdown = attackCountdown - Time.deltaTime;

		if (attackCountdown < 0) 
		{
			anim.SetInteger ("State", 1); // Enter the attack animation
			attackCountdown = timeBetweenAttacks; // Reset the countdown
		} 
		else if (anim.GetInteger("State") == 1) 
		{
			anim.SetInteger ("State", 0); //Go back to idle animation
		}


	}
}
