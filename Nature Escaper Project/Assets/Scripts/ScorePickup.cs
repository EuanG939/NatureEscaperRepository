using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    //public variable
    public int pickupValue = 1;

    //called by unity when this object overlaps
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check if score script is attached to the thing we bumped into
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            //we have a score script so the thing we bumped into is the player
            scoreScript.AddScore(pickupValue);

            //we should then delete this object so we don't infinitely add score
            Destroy(gameObject);
        }
    }
}
