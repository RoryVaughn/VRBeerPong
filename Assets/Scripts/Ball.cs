using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 Position;

	// Use this for initialization
	void Start ()
	{
	    Position = transform.position;
		Events.CupH.AddListener(DestroyBall);
	}

    void DestroyBall()
    {
        transform.position = Position;
    }
	
	
}
