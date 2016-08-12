

using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class turretConntrol : MonoBehaviour {




	public int speed;
	public Transform shootingPoint;
	public GameObject shot;
	public ParticleSystem shootingPointEmitter; 

	Vector3 offset = Vector3.zero;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			fire ();
//			Instantiate (shot, shootingPoint.position, shootingPoint.rotation);
//			shootingPointEmitter.Emit (10);
		}

		offset = new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, 0) + transform.position;

		offset.x = Mathf.Clamp (
			offset.x, 
			Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x + GetComponent<Renderer>().bounds.size.x * 0.5f, 
			Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x - GetComponent<Renderer>().bounds.size.x * 0.5f
		);

		transform.position = offset;
	}

	public void fire(){
		Instantiate (shot, shootingPoint.position, shootingPoint.rotation);
		shootingPointEmitter.Emit (10);
	}
			
}
