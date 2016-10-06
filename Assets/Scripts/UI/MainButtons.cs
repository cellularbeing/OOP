using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class MainButtons : MonoBehaviour {

	public void StartGame(string newGame){
		SceneManager.LoadScene (newGame);
	}
}
