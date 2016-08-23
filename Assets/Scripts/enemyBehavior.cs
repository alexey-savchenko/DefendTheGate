using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour{

	public float damageAmount;
	public int healthPoints;
	public float speed;

	public Transform shootingPoint;
	public GameObject deathEffect;
	public GameObject enemyProjectile; 

	GameObject GM;
	GameManager _gameManager;


	// Update is called once per frame
	void Update () {

		// Movement
		gameObject.transform.Translate (Vector3.down * speed * Time.fixedDeltaTime);
		//end of movement

		//health check
		if(healthPoints == 0){
			Destroy (this.gameObject);
			Object _deathEffect = Instantiate (deathEffect, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
			Destroy (_deathEffect, 1.25f);
		}
		//end of health check
	}

	void Awake(){
		GM = GameObject.FindGameObjectWithTag ("GameController");
		_gameManager = GM.GetComponent<GameManager> ();
		             



		StartCoroutine ("enemyFire");
		
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
		//print (gameManager.gateHealth);
	}


	IEnumerator enemyFire(){

		while(gameObject.activeSelf){
			Instantiate (enemyProjectile, shootingPoint.position, shootingPoint.rotation);
			yield return new WaitForSeconds (Random.Range(2,4));
		}

	}
}
