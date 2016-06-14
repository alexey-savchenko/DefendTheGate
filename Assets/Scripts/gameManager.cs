using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameManager : MonoBehaviour {
	
	public static int gateHealth {
		get;
		set;
	}

	public static int scoreCount {
		get;
		set;
	}

	void Start () {
		
		scoreCount = 0;
		gateHealth = 3;

	}

	void Update(){
		if (gateHealth == 0) {
			GameOver ();
		}
	}

	void GameOver(){
		GameObject.Find ("spawnManager").SetActive(false);
	}
}
