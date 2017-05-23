using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{


    private bool Hit = false;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("DRINK");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

	}
}
