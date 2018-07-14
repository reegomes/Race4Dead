using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	float moveSpeed;
	Rigidbody myRB;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
