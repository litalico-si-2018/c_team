using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyouji_fade : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void hyouji_fade(){
		gameObject.SetActive (true);
		Invoke("DelayMethod", 1f);
	}

	void DelayMethod(){
		gameObject.SetActive (false);
	}

}
