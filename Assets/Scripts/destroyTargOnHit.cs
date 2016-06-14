using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class destroyTargOnHit : MonoBehaviour {

	public GameObject explosion_anim;
	public GameObject blood_anim;



	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			Destroy (this.gameObject);

			///DEAL DAMAGE TO ENEMY
			enemyBehavior target = coll.gameObject.GetComponent<enemyBehavior> ();
			TargetHit (target);
			///

			if (target.healthPoints == 0) {
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
