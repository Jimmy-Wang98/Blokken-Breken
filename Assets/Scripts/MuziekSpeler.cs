using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuziekSpeler : MonoBehaviour {

    static MuziekSpeler instance;

	// Use this for initialization
	void Start () {
		if(instance !=null)
        {
            Destroy(gameObject);
            print("Dubbele muziekspeler gedetecteerd! Start zelfvernietiging!");
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
