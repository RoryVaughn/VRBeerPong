using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    public Vector3 Position = new Vector3(0.055f, 0, -0.422f);
    private bool con;

    private bool Hit = false;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("DRINK");
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        StartCoroutine(Move());

          
    }
	// Use this for initialization
	void Start () {
        con = true;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    private IEnumerator Move()
    {
        for (int i = 0; i < 40; i++)
        {
            transform.Translate(0, 1 * Time.deltaTime, 0);
            yield return 0;
        }
        int counter = 0;
        while (transform.localPosition != Position & con)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, Position, Time.deltaTime);
            counter++;
            if (counter > 500)
            {
                con = false;
            }
            yield return 0;
        }
        StopCoroutine(Move());
    }
}
