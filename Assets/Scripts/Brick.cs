using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int HP;
    int geraakt = 0;
    LevelManager levelmanager;
    static int brickCount;
    AudioSource audiosource;
    public GameObject rookPref;
    public Sprite[] bricks;
    public Sprite[] brickSprites;
    // Use this for initialization
    void Start () {
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
        brickCount++;
        print(brickCount);
        audiosource = GetComponent<AudioSource>();
		
	}
	

    private void OnCollisionEnter2D(Collision2D collision)
       
    {
        audiosource.Play();
        if(collision.transform.name == "Ball")
        {
            geraakt++;
            GetComponent<SpriteRenderer>().sprite = brickSprites[geraakt];
            if (geraakt >= HP)

            {
                brickCount--;
                Destroy(gameObject);
                GameObject rook = Instantiate(rookPref, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
                rook.GetComponent<ParticleSystem>().startColor = GetComponent<SpriteRenderer>().color;
                if (brickCount <= 0)
                    levelmanager.LaadVolgendLevel();
            }
        }
    }
}
