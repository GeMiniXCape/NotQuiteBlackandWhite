using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	public void PressStart() {
        SceneManager.LoadScene("SampleScene");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void PressPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
