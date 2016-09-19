using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	private InputState inputState;
	private Walk walkBehavior;
	private Animator animator;
	private CollisionState collisionState;
	private Climb climbBehavior;

	void Awake(){
		inputState = GetComponent<InputState> ();
		walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
		collisionState = GetComponent<CollisionState> ();
	}

	// Character animation
	void Update () {

		int caseSwitch = 0;

		if (inputState.absVelX > 0 && collisionState.standing) { // walking
			caseSwitch = 1;
		}
		if (!collisionState.standing) { // jumping
			caseSwitch = 2;
		}

		if(collisionState.climbing){ //climbing
			caseSwitch = 4;
		}
		if (collisionState.stunned) {//got hit
			caseSwitch = 5;
		}

		switch (caseSwitch){
		case 1:
			ChangeAnimationState (1); //walking
			break;
		case 2:
			ChangeAnimationState (2); // jumping
			break;
		case 3:
			ChangeAnimationState (3); // shooting
			break;
		case 4:
			ChangeAnimationState (4); // climbing
			break;
		case 5:
			ChangeAnimationState (5); // got hit
			break;
		default:
			ChangeAnimationState (0); // idle
			break;
		}
	}

	void ChangeAnimationState(int value){
		animator.SetInteger ("AnimState", value);
	}
}
