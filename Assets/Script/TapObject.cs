﻿using UnityEngine;
using System.Collections;

public class TapObject : MonoBehaviour {

	public GameObject TargetMonster;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			
			if (aCollider2d) {
				if(aCollider2d.transform.gameObject.tag == "Enemy")
				{
				TargetMonster = aCollider2d.transform.gameObject;
				Debug.Log(TargetMonster.name);
				}
			}
		}
	}
}
