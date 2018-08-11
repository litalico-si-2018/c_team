using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {

	public int station_num;

	// Use this for initialization
	void Start () {
		station_num = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void minus_1(){
		station_num -= 1;
	}

	public void set3(){
		station_num = 3;
	}

	public void set4(){
		station_num = 4;
	}
		
	public void set5(){
		station_num = 5;
	}

}
