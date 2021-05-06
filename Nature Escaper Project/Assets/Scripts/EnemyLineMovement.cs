using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    //public variables exposed for editing in unity editor
    public float forceStrength; //how fast the enemy moves

    public Vector2 direction;

    //Private varibales, not visible in editor used for tracking data while game is running
    private Rigidbody2D ourRigidbody;


    //awake function
    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        //normalise direction, changes it to length 1
        direction = direction.normalized;
    }



    // Update is called once per frame
    void Update()
    {
        //move in correct direction with set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
