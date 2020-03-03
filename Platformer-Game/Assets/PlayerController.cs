using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Living
{
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(Physics2D.Raycast(transform.position, Vector3.down).distance);
        }

        // Move left.
        if (Input.GetKey(KeyCode.A))
        {
            Move(new Vector2(-1, 0));
        }

        // Move right.
        if (Input.GetKey(KeyCode.D))
        {
            Move(new Vector2(1, 0));
        }

        // Jump.
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Move(new Vector2(0, 60));
        }
    }
}
