using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {
    // Use this for initialization
    [SerializeField] Sprite whiteSprite;
    [SerializeField]
    Sprite blackSprite;
    void Start () {
        if (!GameObject.Find("Level1").GetComponent<WorldScript>().blackMode)
        {
            GetComponent<SpriteRenderer>().sprite = blackSprite;

        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = whiteSprite;

        }
    }
    // Update is called once per frame
    void Update () {
        if (!GameObject.Find("Level1").GetComponent<WorldScript>().blackMode)
        {
            GetComponent<SpriteRenderer>().sprite = blackSprite;

        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = whiteSprite;

        }
    }
}
