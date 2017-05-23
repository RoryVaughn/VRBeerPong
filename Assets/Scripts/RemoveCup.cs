using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCup : MonoBehaviour
{
    public Vector3 Position;

    private void OnTriggerEnter(Collider other)
    {
        transform.localPosition = Position;
    }
}
