using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonBehavior : HoldButton{

	public GameObject pauseText;
	public GameObject mainMenuBtn;



	public void loadLevel(){
		
		Text levelSelected = gameObject.GetComponentInChildren<Text> ();

		try{
		SceneManager.LoadScene (levelSelected.text.ToString ());
		} catch {
			print (levelSelected.text);
		}
	}

	public void levelReset(){
		SceneManager.LoadScene (Application.loadedLevel);
	}

	public void exitApp(){
		Application.Quit ();
	}
		
	public void pause(){
		
		if (gameManager.isPaused != true) {
			gameManager.isPaused = true;
			Time.timeScale = 0;
			pauseText.SetActive (true);
			mainMenuBtn.SetActive (true);
		} else {
			gameManager.isPaused = false;
			Time.timeScale = 1;
			pauseText.SetActive (false);
			mainMenuBtn.SetActive (false);
		}
	}

	public void returnToMainMenu(){
		Time.timeScale = 1;
		SceneManager.LoadScene ("Startup Scene");
	}

	// touch input 

	public void fire(){
		turretConntrol i = GameObject.FindGameObjectWithTag ("Player").GetComponent<turretConntrol> ();
		i.fire ();
	}

	public void moveLeft(){
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		Vector3 shift = new Vector3 (-1 * Time.deltaTime * 5, 0 ,0 ) + player.transform.position;

		player.transform.position = shift;
	}
		
	public void moveRight(){
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		Vector3 shift = new Vector3 (1 * Time.deltaTime * 5, 0 ,0 ) + player.transform.position;

		player.transform.position = shift;
	}

	//end of touch input

}
