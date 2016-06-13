using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class destroyTargOnHit : MonoBehaviour {



	public GameObject explosion_anim;
	public GameObject blood_anim;
	private Text scoreText;


	void Awake(){
		//scoreText = GameObject.FindGameObjectWithTag ("score").GetComponent<Text> ();
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "tank_target(Clone)" || coll.gameObject.name == "soldier_enemy(Clone)") {
			Destroy (this.gameObject);

			///DEAL DAMAGE TO ENEMY
			enemyBehavior target = coll.gameObject.GetComponent<enemyBehavior> ();
			TargetHit (target);
			///

			if (coll.gameObject.name == "tank_target(Clone)" && target.healthPoints > 0) {

				if (coll.gameObject.name == "tank_target(Clone)" && target.healthPoints == 0) {
					Object exp = Instantiate (explosion_anim, new Vector3 (coll.gameObject.transform.position.x, coll.gameObject.transform.position.y, 0), Quaternion.identity);
					Destroy (exp, 1.25f);

					UpdateScore ();

				}

			} else if(coll.gameObject.name == "soldier_enemy(Clone)"){
				Object blood = Instantiate (blood_anim, new Vector3 (coll.gameObject.transform.position.x, coll.gameObject.transform.position.y, 0), Quaternion.identity);
				Destroy (blood, 1f);

				UpdateScore ();

			}
		}
	}

	void TargetHit(enemyBehavior target){
		target.healthPoints--;
	}

	void UpdateScore(){
		Text scoreText = GameObject.Find("score").GetComponent<Text>();
		gameManager.scoreCount++;
		scoreText.text = "Body count: " + gameManager.scoreCount;
	}
}
