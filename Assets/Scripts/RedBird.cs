﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using vector = UnityEngine.Vector2;

public class RedBird : MonoBehaviour {

	Rigidbody2D bird;
	Vector2 up = vector.up * 20;
	Vector2 down = vector.down * 20;
	Vector2 left = vector.left * 20;
	Vector2 right = vector.right * 20;

	void Start () {
		bird = gameObject.GetComponent<Rigidbody2D>();
	}
	

	void Update () {

		if (OnKey("up")){
			bird.AddForce(up);
		}
		if (OnKey("down")){
			
		}
	}

	// Helpers - Don't touch! =================
	bool OnKey(string keyName) { return Input.GetKey(keyName); }
}
