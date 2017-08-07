using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 10.0f;
		var y = Input.GetAxis ("Vertical") * Time.deltaTime * 10.0f;
	
		transform.Translate (x, 0, 0);
		transform.Translate (0, y, 0);
	}
}
