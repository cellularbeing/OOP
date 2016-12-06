using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpearTrapColliderKill : MonoBehaviour {
	private Animator animP;
	private AudioSource audio;
	private Text loseText;

	// Use this for initialization
	void Start () {
		animP = this.transform.parent.gameObject.GetComponent<Animator>();
		audio = this.GetComponent<AudioSource> ();
		loseText = GameObject.Find("WinText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LoadNextLevel() {
		SceneManager.LoadScene ("Level 1");
	}

	void OnTriggerStay2D (Collider2D other) {

		if (other.gameObject.CompareTag ("Player") && animP.GetCurrentAnimatorStateInfo(0).IsName("SpearTrap_Attack")) {
			Destroy(other.gameObject);
			audio.Play ();
			loseText.text = "Game Over";
			Invoke ("LoadNextLevel", 2);
		}
	}
}
	
