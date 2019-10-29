using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
	private bool _isDragged;
	private Vector3 mousePosition;

	public void OnDrag()
	{
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePosition.z = 1;
		transform.position = mousePosition;
	}
}