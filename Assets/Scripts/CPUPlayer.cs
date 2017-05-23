using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class CPUPlayer : MonoBehaviour
{
   
    public GameObject Ball;
    public Vector3 Throw;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown("space"))
	    {
            Throw = new Vector3(Random.Range(4.0f,7.0f),Random.Range(1.0f,3.0f), Random.Range(-1.0f,1.0f));
	        Ball.transform.position = new Vector3(-2,3,0);
	        Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Ball.GetComponent<Rigidbody>().AddForce(Throw, ForceMode.Impulse);

	    }
	}
}
