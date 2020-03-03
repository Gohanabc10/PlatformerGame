using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class KillVolume : MonoBehaviour
{
    // Run "Die" code on any object that touches this one that contains the "Living" component.
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Living>()?.Die();
    }
}
