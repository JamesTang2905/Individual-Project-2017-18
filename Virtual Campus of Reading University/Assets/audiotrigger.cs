using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiotrigger : MonoBehaviour {

    public AudioClip music;
    private AudioSource source;
    public bool played = false;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    //Activates when users collides with the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !played) // Runs when the user collides with the trigger
        {
            source.Play();
            played = true;
        }
        played = false;
    }
}