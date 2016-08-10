using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameManager : MonoBehaviour {

	public Slider healthBar;
	public GameObject GameOverWrap;

	public static bool isPaused = false;

	public static float gateHealth {
		get;
		set;
	}

	public static int scoreCount {
		get;
		set;
	}

	void Start () {
		gateHealth = 1;
		healthBar.value = gateHealth;

		scoreCount = 0;


	}

	void Update(){
		if (gateHealth < 0) {
			GameOver ();
			GameOverWrap.SetActive (true);

		}
	}

	public void damageGate(float amount){

		gateHealth -= amount;
		healthBar.value = gateHealth;


	}

	void GameOver(){
		GameObject.Find ("Script - SpawnManager").SetActive(false);
	}
}
