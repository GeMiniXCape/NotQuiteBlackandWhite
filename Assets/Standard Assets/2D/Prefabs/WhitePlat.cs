using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameObject.Find("Level1").GetComponent<WorldScript>().blackMode)
        {

            if (GetComponent<SpriteRenderer>() != null) { 
                GetComponent<SpriteRenderer>().enabled = true;
            }
            if (GetComponent<BoxCollider2D>() != null) { 
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        else
        {
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            if (GetComponent<BoxCollider2D>() != null)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
