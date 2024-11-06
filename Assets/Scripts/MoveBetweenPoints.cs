using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetweenPoints : MonoBehaviour
{
    public Vector3 startCoordinates;  // The start position coordinates
    public Vector3 endCoordinates;    // The end position coordinates
    public float speed = 0.3f;       // Speed of movement

    private Vector3 currentTarget;   // The current target position

    void Start()
    {
        startCoordinates = gameObject.transform.position;
        endCoordinates = new Vector3(startCoordinates.x, startCoordinates.y + 1, startCoordinates.z);
        currentTarget = endCoordinates; // Start at the end position
    }

    void Update()
    {
        // Move towards the current target
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        // Check if the obstacle has reached the current target
        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            // Switch the target position
            if (currentTarget == endCoordinates)
                currentTarget = startCoordinates;
            else
                currentTarget = endCoordinates;
        }
    }
}