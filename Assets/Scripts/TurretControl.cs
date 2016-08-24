using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour {

	public float playerHealth;
	public int speed;
	public Transform shootingPoint;
	public GameObject shot;
	public ParticleSystem shootingPointEmitter; 
	public Slider playerHealthBar;


	Vector3 offset = Vector3.zero;
    Animator turretAnimator;

    void Awake ()
    {
        CacheComponents();
    }

    void CacheComponents ()
    {
        turretAnimator = GetComponent<Animator>();
    }

	void Start(){
		playerHealth = 10;
		playerHealthBar.value = playerHealth;
	}

	void Update () {

		offset = new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, 0) + transform.position;

		offset.x = Mathf.Clamp (
			offset.x, 
			Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x + GetComponent<Renderer>().bounds.size.x * 0.5f, 
			Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x - GetComponent<Renderer>().bounds.size.x * 0.5f
		);

		transform.position = offset;


		if (playerHealth < 0){
			GameManager _gameManager = GameObject.Find ("Script - GameManager").GetComponent<GameManager>();
			_gameManager.GameOver ();
		}

		playerHealthBar.value = playerHealth;

	}

	public void fire(){
		Instantiate (shot, shootingPoint.position, shootingPoint.rotation);
		shootingPointEmitter.Emit (10);
        turretAnimator.SetTrigger("Fire");

    }
			
}
