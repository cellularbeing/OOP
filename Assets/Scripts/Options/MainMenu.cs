using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public Canvas exitMenu;
	public Canvas creditMenu;
	public Canvas scoreMenu;
	public Canvas playMenu;

	public Button startText;
	public Button exitText;
	public Button mainMenuText0;
	public Button mainMenuText1;
	public Button mainMenuText2;
	public Button newGameText;
	public Button scoreText;
	public Button playText;

	public GameObject gm;

	public Text score0;
	public Text score1;
	public Text score2;


	// Use this for initialization
	void Start () {
		gm = GameObject.Find("GM");

		exitMenu = exitMenu.GetComponent<Canvas> ();
		creditMenu = creditMenu.GetComponent<Canvas> ();
		scoreMenu = scoreMenu.GetComponent<Canvas> ();
		playMenu = playMenu.GetComponent<Canvas> ();

		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		mainMenuText0 = mainMenuText0.GetComponent<Button> ();
		mainMenuText1 = mainMenuText1.GetComponent<Button> ();
		mainMenuText2 = mainMenuText2.GetComponent<Button> ();
		newGameText = newGameText.GetComponent<Button> ();
		scoreText = scoreText.GetComponent<Button> ();
		playText = playText.GetComponent<Button> ();

		exitMenu.enabled = false; //exit menu is disabled
		creditMenu.enabled = false; //credit menu is disabled
		scoreMenu.enabled = false; //score menu is disabled
		playMenu.enabled = false; //how to play menu is disabled

	}
	
	//press exit button
	public void ExitPress() {
		
		exitMenu.enabled = true; //enable exit menu
		startText.enabled = false; //disable start button
		exitText.enabled = false; //disable
		newGameText.enabled = false; //disable
		
	}
	
	//go back to main menu when no is pressed in exit menu
	public void NoPress() {
		
		exitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		newGameText.enabled = true;

	}

	public void PlayPress() {
	
		playMenu.enabled = true;
		mainMenuText1.enabled = true;

	}

	
	//go back to main menu
	public void MenuPress() {
		playMenu.enabled = false;
	}
	
	//press start game button
	public void StartLevel() {
		
	}
	
	//press yes to exit game
	public void ExitGame() {

		Application.Quit (); //quits game

	}

	//go to character selection scene
	public void NewGamePress() {
		Application.LoadLevel (1);

	}



}
