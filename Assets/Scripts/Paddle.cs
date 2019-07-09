using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 curserPositie = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(curserPositie.x, transform.position.y);
	}
}
