﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileSelectionHandler : MonoBehaviour {
	public static List<GameObject> selectedObjects = new List<GameObject>();
	private Color defaultColor;

	void OnMouseUp() {
		if(selectedObjects.Contains (gameObject)){
			gameObject.GetComponent<Renderer>().material.SetColor ("_Color", defaultColor);
			selectedObjects.Remove(gameObject);
		}else{
			Debug.Log ( string.Format ("gameObject: {0}", gameObject.name));
			gameObject.GetComponent<Renderer>().material.SetColor ("_Color", Color.green);
			selectedObjects.Add(gameObject);
		}
	}
	
	void Start () {
		defaultColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
	}
}
