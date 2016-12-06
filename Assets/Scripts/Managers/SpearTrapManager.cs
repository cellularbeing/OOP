using UnityEngine;
using System.Collections;

public class SpearTrapManager : MonoBehaviour {

	Animator anim;
	GameObject colliderChild;
	BoxCollider2D bc;
	[SerializeField] private float timeBetweenAttacks = 5.0f;
	[SerializeField] private float timeBeforeActivation = 0.0f;
	private float attackCountdown;
	private float cMoveSum = 0f;
	private float cMoveSpeed = 0.12f;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
		colliderChild = transform.GetChild(0).gameObject;
		bc = colliderChild.GetComponent<BoxCollider2D>();

		attackCountdown = timeBetweenAttacks + timeBeforeActivation;

	}

	// Update is called once per frame
	void Update () 
	{
		attackCountdown = attackCountdown - Time.deltaTime;


		if (anim.GetCurrentAnimatorStateInfo(0).IsName("SpearTrap_Attack")) { //in attack state

			if (cMoveSum <= 2.7f) {
				bc.transform.Translate (0, cMoveSpeed, 0);
				cMoveSum = cMoveSum + cMoveSpeed;
			} 
			else {
				bc.transform.Translate (0, -cMoveSpeed, 0);
			}
		}


		if (attackCountdown < 0) 
		{
			anim.SetInteger ("State", 1); // Enter the attack animation
			attackCountdown = timeBetweenAttacks; // Reset the countdown
		} 
		else if (anim.GetInteger("State") == 1) //in attack anim
		{
			anim.SetInteger ("State", 0); //Go back to idle animation

		}

		if (anim.GetCurrentAnimatorStateInfo(0).IsName("SpearTrap_Idle")) {
			cMoveSum = 0;
			//RESET POSITION OF COLLIDER
			bc.transform.localPosition = new Vector3(0, 0, 0);
		}

	}


}
		
