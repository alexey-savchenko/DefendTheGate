using UnityEngine;
using System.Collections;

public class enemyBehavior : MonoBehaviour{

	public float damageAmount;
	public GameObject deathEffect;
	public int healthPoints;
	public float speed;

	GameObject GM;
	gameManager _gameManager;


	// Update is called once per frame
	void Update () {

		// Movement
		gameObject.transform.Translate (Vector3.down * speed * Time.fixedDeltaTime);

		if(healthPoints == 0){
			Destroy (this.gameObject);
			Object _deathEffect = Instantiate (deathEffect, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
			Destroy (_deathEffect, 1.25f);
		}

	}

	void Awake(){
		GM = GameObject.FindGameObjectWithTag ("GameController");
		_gameManager = GM.GetComponent<gameManager> ();


	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "deathZone")
		{
			damageGate(damageAmount);
			Destroy(this.gameObject);
		}
	}

	void damageGate(float amount){

		_gameManager.damageGate (amount);
		print (gameManager.gateHealth);

	}

}
