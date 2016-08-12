using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HoldButton: MonoBehaviour, IPointerDownHandler, IPointerExitHandler
{
	public UnityEvent OnHeld;
	public UnityEvent OnClick;


	bool isHeld = false;

	void Update () {
		if (isHeld)
			OnHeld.Invoke ();
	}

	public void OnPointerDown(PointerEventData eventData){
		isHeld = true;
		OnClick.Invoke ();
	}

	public void OnPointerExit (PointerEventData eventData){
		isHeld = false;
	}


}