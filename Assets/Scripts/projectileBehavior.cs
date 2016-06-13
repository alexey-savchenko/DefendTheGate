using UnityEngine;
using System.Collections;

public class projectileBehavior : MonoBehaviour {


	public float projectileSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,1 * projectileSpeed * Time.deltaTime,0);
		Destroy(this.gameObject, 5);
	}





}
