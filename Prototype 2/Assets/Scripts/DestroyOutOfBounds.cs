using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 35;
    private float lowerBoundary = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /// Destroy the projectile when passed the top boundary
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        /// If the animal reaches the lower bound, show game over
        else if (transform.position.z < lowerBoundary)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}
