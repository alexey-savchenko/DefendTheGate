using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameManager : MonoBehaviour {

	public Slider healthBar;

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
		}
	}

	public void damageGate(float amount){

		gateHealth -= amount;
		healthBar.value = gateHealth;


	}

	void GameOver(){
		GameObject.Find ("spawnManager").SetActive(false);
	}
}
