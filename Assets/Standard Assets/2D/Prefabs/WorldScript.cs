using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldScript : MonoBehaviour
{

    // Use this for initialization
    [SerializeField]
    public bool blackMode;
    [SerializeField]
    public float Health = 100.0f;
    public bool hasStar;
    public bool hasMoon;
    AudioSource audioData;
    [SerializeField] public string scene;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasStar && hasMoon)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }
    }

    public void boundShift(bool input)
    {
        blackMode = input;
    }

    bool getblackMode()
    {
        return blackMode;
    }

    public void setStar(bool input)
    {
        hasStar = input;
    }

    public void setMoon(bool input)
    {
        hasMoon = input;
    }
}
