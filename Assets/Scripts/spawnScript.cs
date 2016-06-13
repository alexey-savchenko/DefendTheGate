using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public float timeOffset;
    public GameObject[] targets;
	public float y_spawnOffset;
	private Vector3 spawnPos;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeOffset -= Time.deltaTime;
		if (timeOffset < 0.1f) {
			Instantiate (targets[Random.Range(0, targets.Length)], new Vector3 (Random.Range(-3.8f, 3.8f), y_spawnOffset, 0), Quaternion.identity);
			timeOffset = Random.Range(1, 3);
		}

	}


}
