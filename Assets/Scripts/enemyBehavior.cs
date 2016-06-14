using UnityEngine;
using System.Collections;

public class enemyBehavior : MonoBehaviour{

	public GameObject deathEffect;
	public int healthPoints;
	public Vector3 MoveDirection;


	// Update is called once per frame
	void Update () {

		// Movement
		gameObject.transform.Translate (-MoveDirection);

		if(healthPoints == 0){
			Destroy (this.gameObject);
			Object _deathEffect = Instantiate (deathEffect, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
			Destroy (_deathEffect, 1.25f);
		}

	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "danger_zone")
		{
			gameManager.gateHealth--;
			Destroy(this.gameObject);
		}
	}


}
