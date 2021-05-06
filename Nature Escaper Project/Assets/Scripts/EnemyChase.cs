using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    //public variables
    public float forceStrength; //how fast we move
    public Transform target; //the thing you want to chase

    //private variables
        private Rigidbody2D ourRigidbody;
    
    
    
    //called when the script first loads
    void Awake()
    {
        //Get the rigidbody that we will be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move in direction of our target

        //get direction
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        //move in correct direction with set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
