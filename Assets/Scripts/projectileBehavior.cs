using UnityEngine;
using System.Collections;

public class projectileBehavior : MonoBehaviour {
	
	public float projectileSpeed;

	void Update () {
		transform.Translate (0,1 * projectileSpeed * Time.deltaTime,0);
		Destroy(this.gameObject, 5);
	}

}
