using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //public variables
    public float forceStrength; //how fast we move
    public Vector2[] patrolPoints; //patrol points we will move to
    public float stopDistance; //how close we get before moving to next patrol point

    //private variables
    private Rigidbody2D ourRigidbody;
    private int currentPoint = 0; //index of current point we're moving towards
    
    //Called when script is loaded
    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //how far are we from our target?
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        if(distance <= stopDistance)
        {
            currentPoint = currentPoint + 1;

            //if we've gone past the end of our list
            if (currentPoint >=patrolPoints.Length)
            {
                //then loop back to thr start, by setting current index to 0
                currentPoint = 0;
            }

        }
        
        
        
        //Move in direction of our target, get the direction we should move in
        Vector2 direction = patrolPoints[currentPoint] - (Vector2)transform.position;
        direction = direction.normalized;

        //move in correct direction with set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
