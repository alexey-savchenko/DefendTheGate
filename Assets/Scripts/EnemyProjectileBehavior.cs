using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyProjectileBehavior : MonoBehaviour {

	public float enemyProjectileDamage;
	public float projectileSpeed;

	void Update () {
		transform.Translate (0,projectileSpeed * Time.deltaTime,0);
		Destroy(this.gameObject, 3);
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			Destroy (this.gameObject);

			///DEAL DAMAGE TO PLAYER
			TurretControl target = coll.gameObject.GetComponent<TurretControl> ();
			TargetHit (target);
			///
		}
	}

	void TargetHit(TurretControl player){
		player.playerHealth -= enemyProjectileDamage;
		print ("Player health - " + player.playerHealth);
	}
}
