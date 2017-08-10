using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public float movespeed = 10.0f;
	public Rigidbody2D playerRB;

	void Start () {

//      Setting up Movement Animations
//		Animator playeranim;
		playerRB = GetComponent<Rigidbody2D>();
		playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	// Update is called once per frame
	void Update () {
//		transform.Translate (x, 0, 0);
//		transform.Translate (0, y, 0);

		Vector2 movement = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));

		playerRB.velocity = movement * movespeed;
	}
}
