using UnityEngine;
using System.Collections;

public class enemyBehavior : MonoBehaviour{


	public int healthPoints;
	public Vector3 MoveDirection;


	// Update is called once per frame
	void Update () {

		// Movement
		gameObject.transform.Translate (-MoveDirection);

		if(healthPoints == 0){
			Destroy (this.gameObject);
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
