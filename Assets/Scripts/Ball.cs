using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    Paddle paddle;
    bool gestart = false;
    AudioSource audiosource;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        audiosource = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audiosource.Play();
    }
    // Update is called once per frame
    void Update () {
        if(!gestart)
        {
            transform.position = new Vector2(paddle.transform.position.x, paddle.transform.position.y + 0.7f);
        }
        if(Input.GetMouseButtonDown(0) && !gestart)
        {
            gestart = true;
            Vector2 snelheid = new Vector2(5f, 5f);
            GetComponent<Rigidbody2D>().velocity = snelheid;
        }
	}
}
