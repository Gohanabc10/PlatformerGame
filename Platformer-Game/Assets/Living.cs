using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Anything that can "Die" inherits this class.
[RequireComponent(typeof(Rigidbody2D))]
public class Living : MonoBehaviour
{
    [Tooltip("The speed multiplier for this character. Default = 10.")]
    public float moveSpeed = 10;

    private Rigidbody2D rb;

    // Needs to be called by start method of inheriting classes.
    public void Initialize()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Cause this object to "Die".
    public void Die()
    {
        Destroy(gameObject);
    }
    
    public void Move(Vector2 dir)
    {
        rb.AddForce(dir * moveSpeed);
    }
}
