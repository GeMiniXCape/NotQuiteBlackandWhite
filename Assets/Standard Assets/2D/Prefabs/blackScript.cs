using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackScript : MonoBehaviour {
    // Use this for initialization
    public GameObject blackParts;
    bool alreadyDone = false;
    void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameObject.Find("Level1").GetComponent<WorldScript>().blackMode)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}

