using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	public int movementSpeed;
	public int rotateSpeed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up, Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.down, Input.GetAxis ("Horizontal") * -1 * rotateSpeed * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0, Input.GetAxis ("Vertical") * movementSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, 0, Input.GetAxis ("Vertical") * -1 * movementSpeed * Time.deltaTime);
		}
	}
}
