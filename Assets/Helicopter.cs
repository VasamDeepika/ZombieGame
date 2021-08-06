using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private bool isCalledHelicopter;
    AudioSource audiohelicopter;
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        audiohelicopter = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Helicopter") && !isCalledHelicopter)
        {

            isCalledHelicopter = true;
            audiohelicopter.clip = sound;
            audiohelicopter.Play();
            print("Called");
        }
    }
}


