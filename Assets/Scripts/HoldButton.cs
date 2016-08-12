using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HoldButton: Button, IPointerDownHandler, IPointerExitHandler
{
	protected bool isHeld = false;

	void OnPointerDown(PointerEventData eventData){




//		isHeld = true;
//		if (gameObject.name == "Move left - Button ") {
//			Rigidbody2D player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ();
//			player.AddForce (new Vector2 (-1 * Time.deltaTime * 100, 0));
//		} else if (gameObject.name == "Move right - Button ") {
//			Rigidbody2D player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ();
//			player.AddForce (Vector2.right * Time.deltaTime);
//		}
	}
//
//	void OnPointerExit (PointerEventData eventData){
//		
//	}


}

