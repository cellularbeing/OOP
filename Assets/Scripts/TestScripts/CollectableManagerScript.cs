using UnityEngine;
using System.Collections;

public class CollectableManagerScript : MonoBehaviour {

	private GameObject[] spawnPoints; 
	private int currentIndex = -1; //a value of -1 indicates the currentIndex has not been initialized
	private int numCollected = 0;
	public int maxCollectables = 2; //the total number of collectables the player must pick up to complete the level
	public Transform collectablePrefab;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
		spawnPoints = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
		{
			spawnPoints[i] = transform.GetChild(i).gameObject; //populate the spawnPoints array with the children of the CollectableManager
		}
			
		currentIndex = Random.Range (0, transform.childCount); //randomly choose an initial spawn point for the first collectable
		Vector3 vec = spawnPoints[currentIndex].transform.position; 
		Instantiate(collectablePrefab, vec, Quaternion.identity); //spawn the collectable prefab
		audioSource = GetComponent<AudioSource>();
	
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnCollectNotification() {
		audioSource.Play ();
		numCollected++;
		if (numCollected == maxCollectables) {
			//level has been completed
		}
		else {
		int newIndex = Random.Range (0, transform.childCount); //randomly choose a new spawn point for the next collectable
			if (newIndex == currentIndex) { //don't let collectable spawn in the same spot twice
				newIndex = ++newIndex % transform.childCount;
			}
			currentIndex = newIndex; //update current index
			Vector3 vec = spawnPoints[currentIndex].transform.position; 
			Instantiate(collectablePrefab, vec, Quaternion.identity); //spawn the new collectable prefab
		}
	}
}
