using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_train : MonoBehaviour {

    private int count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position += new Vector3(0, 0, 1);
        float scale_size = 0.1f;
        int finish_count = 70;

        if (count < finish_count)
        {
            transform.localScale += new Vector3(scale_size, scale_size, 0);
            count += 1;
        }
	}
}
