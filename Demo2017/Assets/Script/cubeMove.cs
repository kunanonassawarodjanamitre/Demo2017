﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour {

	public Rigidbody rg;

	// Use this for initialization
	void Start () {
		rg.velocity = new Vector3 (-1,1,0);
		//rg.AddForce(-1,0,0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}