using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCup : MonoBehaviour
{
    public Vector3 Position = new Vector3(0.055f, 0, -0.422f);
    private bool con;

    void Start()
    {
        con = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Move());
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
