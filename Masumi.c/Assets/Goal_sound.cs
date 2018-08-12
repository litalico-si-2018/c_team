using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_sound : MonoBehaviour {

    public AudioClip goalSound;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource> ();
        audioSource.PlayOneShot(goalSound);
	}
	
	// Update is called once per frame
	void Update () {
        //audioSource.PlayOneShot(goalSound);
	}
}
