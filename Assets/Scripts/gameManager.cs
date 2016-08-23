using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Slider gateHealthBar;

	public float timeOffset;
	public GameObject[] targets;
	public float y_spawnOffset;
	public bool gameOver;
	private Vector3 spawnPos;
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
		gateHealthBar.value = gateHealth;
		scoreCount = 0;
	}

	void Update(){

		if (gateHealth < 0) {
			GameOver ();
		}

		//SPAWN ENEMIES
		if (!gameOver){
			timeOffset -= Time.deltaTime;
			if (timeOffset < 0.1f) {
				Instantiate (targets[Random.Range(0, targets.Length)], new Vector3 (Random.Range(-3.8f, 3.8f), y_spawnOffset, 0), Quaternion.identity);
				timeOffset = Random.Range(1, 3);
			}
		}
		//END OF SPAWN

	}

	public void damageGate(float amount){
		gateHealth -= amount;
		gateHealthBar.value = gateHealth;
	}

	public void GameOver(){

		gameOver = true;

		//GameObject GameOverWrap = GameObject.Find ("Game Over UI wrapper");
		GameOverWrap.SetActive (true);
	}
}
