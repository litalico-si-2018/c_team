using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Susumu_4 : MonoBehaviour {

    int count_3 = 0;
    //int count_4 = 0;
    int count_5 = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void susumu_3(){
		//transform.position += new Vector3 (0, -2.0f, 0);
        switch (count_3)
        {
            case 0:
                //transform.position += new Vector3 (0, -2.0f, 0);
                transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0.5f, 0), Time.deltaTime);
                break;
            case 1:
                transform.position = Vector3.Lerp(transform.position, new Vector3(0, -1.5f, 0), Time.deltaTime);
                break;
            case 2:
                transform.position = Vector3.Lerp(transform.position, new Vector3(0, -3.5f, 0), Time.deltaTime);
                break;
            default:
                break;
        }
        count_3++;
	}

    public void susumu_4()
    {
        transform.position += new Vector3(0, -2.0f, 0);
    }

    public void susumu_5()
    {
        //transform.position += new Vector3(0, -2.0f, 0);

        switch (count_5)
        {
            case 0:
                //transform.position = Vector3.Lerp(transform.position, new Vector3(1.5f, 2, 0), Time.deltaTime);
                transform.position = new Vector3(1.5f, 2, 0);
                break;   
            case 1:
                //transform.position = Vector3.Lerp(transform.position, new Vector3(1.5f, -0.5f, 0), Time.deltaTime);
                transform.position = new Vector3(1.5f, -0.5f, 0);
                break;  
            case 2:
                //transform.position = Vector3.Lerp(transform.position, new Vector3(-1.5f, -0.5f, 0), Time.deltaTime);
                transform.position = new Vector3(-1.5f, -0.5f, 0);
                break;
            case 3:
                //transform.position = Vector3.Lerp(transform.position, new Vector3(-1.5f, -3, 0), Time.deltaTime);
                transform.position = new Vector3(-1.5f, -3, 0);
                break;
            case 4:
                //transform.position = Vector3.Lerp(transform.position, new Vector3(1.5f, -3, 0), Time.deltaTime);
                transform.position = new Vector3(1.5f, -3, 0);
                break;
            default: 
                break;        
        }
        count_5++;
    }
}
