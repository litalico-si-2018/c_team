using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_last_station : MonoBehaviour {

	public GameObject goal_panel;
	public GameObject omedetou_panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D(Collision2D coll){
		if (coll.gameObject.tag == "Goal"){
			omedetou_panel.SetActive (false);
			goal_panel.SetActive (true);
		}
	}
}
