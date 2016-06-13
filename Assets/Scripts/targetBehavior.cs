using UnityEngine;
using System.Collections;

public class targetBehavior : MonoBehaviour {

	public Vector3 fallDirection;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Movement
		gameObject.transform.Translate (-fallDirection);

		//

	}


}
