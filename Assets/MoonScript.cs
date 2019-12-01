using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player"))
        {
            GameObject.Find("Level1").GetComponent<WorldScript>().setMoon(true);
            GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
