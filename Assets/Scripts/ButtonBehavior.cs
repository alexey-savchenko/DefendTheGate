using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonBehavior : MonoBehaviour {

	public GameObject pauseText;
	public GameObject mainMenuBtn;

	public void loadFirstLevel(){
		SceneManager.LoadScene ("1");
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
		SceneManager.LoadScene ("startupScene");
	}
}
