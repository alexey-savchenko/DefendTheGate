using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyTargOnHit : MonoBehaviour {

	public GameObject explosion_anim;
	public GameObject blood_anim;



	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			Destroy (this.gameObject);

			///DEAL DAMAGE TO ENEMY
			EnemyBehavior target = coll.gameObject.GetComponent<EnemyBehavior> ();
			TargetHit (target);
			///

			if (target.healthPoints == 0) {
				UpdateScore ();
			}
		}
	}

	void TargetHit(EnemyBehavior target){
		target.healthPoints--;
	}

	void UpdateScore(){
		Text scoreText = GameObject.Find("Score - Text").GetComponent<Text>();
		GameManager.scoreCount++;
		scoreText.text = "Body count: " + GameManager.scoreCount;
	}
}
