using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Susumu_4 : MonoBehaviour {

    int count_3 = 0;
    int count_4 = 0;
    int count_5 = 0;
    private int switch_idou;
    private Vector3 startP;
    private Vector3 endP;
    private float timeP;

	// Use this for initialization
	void Start () {
        switch_idou = 0;
        //ここが関数発動するためのコード
        //idou(new Vector3(0, 0, 0), new Vector3(2f, 0, 0), 1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (switch_idou == 1)
        {
            transform.position += (endP - startP) / (50 * timeP);
            //Debug.Log((transform.localPosition - endP).magnitude);
        }
        if ((transform.localPosition - endP).magnitude < 1.6f)
        {
            switch_idou = 0;
        }
	}

    void idou(Vector3 start, Vector3 end, float time)
    {
        startP = start;
        endP = end;
        timeP = time;
        switch_idou = 1;
    }

	public void susumu_3(){
        switch (count_3)
        {
            case 0:
                //Debug.Log(transform.localPosition);
                idou(transform.position, new Vector3(0, 0.5f, 0), 1.5f);
                //Debug.Log(transform.localPosition);
                break;
            case 1:
                idou(transform.position, new Vector3(0, -1.5f, 0), 1.5f);
                break;
            case 2:
                idou(transform.position, new Vector3(0, -3.5f, 0), 1.5f);
                break;
            default:
                break;
        }
        count_3++;
	}

    public void susumu_4()
    {
        switch (count_4)
        {
            case 0:
                idou(transform.position, new Vector3(0, 0.8f, 0), 1.5f);
                //Debug.Log(transform.position);
                break;
            case 1:
                idou(transform.position, new Vector3(0, -0.8f, 0), 1.5f);
                //Debug.Log(transform.position);
                break;
            case 2:
                idou(transform.position, new Vector3(0, -2.4f, 0), 1.5f);
                //Debug.Log(transform.position);
                break;
            case 3:
                idou(transform.position, new Vector3(0, -4f, 0), 1.5f);
                Debug.Log(transform.position);
                break;
            default:
                break;
        }
        count_4++;
    }

    public void susumu_5()
    {
        //transform.position += new Vector3(0, -2.0f, 0);
        switch (count_5)
        {
            case 0:
                //idou(transform.position, new Vector3(1.5f, 2f, 0), 1.5f);
                idou(transform.position, new Vector3(3f, 3f, 0), 1.5f);
                Debug.Log(transform.position);
                break;   
            case 1:
                //idou(transform.position, new Vector3(1.5f, -0.5f, 0), 1.5f);
                idou(transform.position, new Vector3(1.5f, -1f, 0), 1.5f);
                Debug.Log(transform.position);
                break;  
            case 2:
                idou(transform.position, new Vector3(-3.1f, 0.5f, 0), 1.5f);
                Debug.Log(transform.position);
                break;
            case 3:
                idou(transform.position, new Vector3(-1.5f, -3.5f, 0), 1.5f);
                Debug.Log(transform.position);

                break;
            case 4:
                idou(transform.position, new Vector3(3f, -2f, 0), 1.5f);
                break;
            default: 
                break;        
        }
        count_5++;
    }
}
