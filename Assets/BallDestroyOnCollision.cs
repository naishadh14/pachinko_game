using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object colliding is the box
        if (collision.gameObject.tag == "Box")
        {
            // Destroy the ball object after 1 second
            Destroy(gameObject);
        }
    }
}
