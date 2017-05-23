using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restack : MonoBehaviour
{
    public Vector3 originalPosition;

	// Use this for initialization
	void Start ()
	{
	    originalPosition = transform.position;
	}
	
	// Update is called once per frame
    void Consolidation()
    {
        transform.position = originalPosition;
    }
}
