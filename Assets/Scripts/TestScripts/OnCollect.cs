using UnityEngine;
using System.Collections;

public class OnCollect : MonoBehaviour {

	private GameObject manager;
	private CollectableManagerScript cms;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find ("CollectableManager");
		cms = manager.GetComponent<CollectableManagerScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.CompareTag ("Player")) {
			
			cms.OnCollectNotification (); //let the CollectableManager know a collectable has been picked up
			Destroy(gameObject);
		}
	}

}
