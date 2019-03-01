using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using vector = UnityEngine.Vector2;

public class BlueBird : MonoBehaviour {

	Rigidbody2D bird;
	Vector2 up = vector.up * 5;
	Vector2 down = vector.down * 5;
	Vector2 left = vector.left * 5;
	Vector2 right = vector.right * 5;
	float timeFlying = 0.0f;
	float timeToChangeDirection = 1.0f;
	Vector2 currentDirection;

	void Start () {
		bird = gameObject.GetComponent<Rigidbody2D>();
		currentDirection = up;
	}
	

	void Update () {
		timeFlying += Time.deltaTime;
		if (timeFlying > timeToChangeDirection)
		{
			timeFlying = 0.0f;
			int direction = Random.Range(0, 4);
			switch (direction)
			{
				case 0:
					currentDirection = up;
					break;
				case 1:
					currentDirection = down;
					break;
				case 2:
					currentDirection = left;
					break;
				case 3:
					currentDirection = right;
					break;
				default:
					currentDirection = right;
					break;
			}
		}
		
		bird.AddRelativeForce(currentDirection);
	}

	// Helpers - Don't touch! =================
	bool OnKey(string keyName) { return Input.GetKey(keyName); }
}
