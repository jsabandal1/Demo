﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 600 * Time.deltaTime, ForceMode.Impulse);
        }
	}
}
