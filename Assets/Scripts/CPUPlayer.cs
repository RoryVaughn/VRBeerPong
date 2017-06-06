using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class CPUPlayer : MonoBehaviour
{
    public GameObject Ball;
    public GameObject CupSetObject;
    public List<Transform> CupSet = new List<Transform>();
    public float DifficultyNumber;
    private Vector2 RandomOffSetX, RandomOffSetY, RandomOffSetZ;
    private Vector3 Throw;
	// Use this for initialization
	void Start ()
    {
		Events.CupHit.AddListener(RemoveCup);
        foreach (Transform child in CupSetObject.transform)
        {
            CupSet.Add(child);
        }
    }

    void RemoveCup(Cup a)
    {
        CupSet.Remove(a.gameObject.transform);
    }

	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown("space"))
	    {
            // Find an average location between all the cups.
	        Vector3 AverageRange = new Vector3(0, 0, 0);
	        foreach (Transform b in CupSet)
	        {
	            AverageRange += b.position;
	        }
	        AverageRange /= CupSet.Count;

            // Make the random offsets.
	        RandomOffSetX.x = AverageRange.x - DifficultyNumber + 1.5f;
	        RandomOffSetX.y = AverageRange.x + DifficultyNumber + 1.5f;
	        RandomOffSetY.x = AverageRange.y - DifficultyNumber;
	        RandomOffSetY.y = AverageRange.y + DifficultyNumber + 3.5f;
	        RandomOffSetZ.x = AverageRange.z - DifficultyNumber;
	        RandomOffSetZ.y = AverageRange.z + DifficultyNumber;

            // Make the throwing point.
            Throw = new Vector3(
                Random.Range(RandomOffSetX.x, RandomOffSetX.y), // 4.0f,7.0f
                Random.Range(RandomOffSetY.x, RandomOffSetY.y), // 1.0f,3.0f
                Random.Range(RandomOffSetZ.x, RandomOffSetZ.y) // -1.0f,1.0f
                );

            // And throw it!
	        Ball.transform.position = new Vector3(-2,3,0);
	        Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Ball.GetComponent<Rigidbody>().AddForce(Throw, ForceMode.Impulse);

	    }
	}
}
