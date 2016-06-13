using UnityEngine;
using System.Collections;

public class turretConntrol : MonoBehaviour {

	public int speed;
	public Transform spawnZone;
	public GameObject shot;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (shot, spawnZone.position, spawnZone.rotation);
		}

		transform.Translate (new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, 0));

	}
			
}
