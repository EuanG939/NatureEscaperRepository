using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //amount of damage the hazard does, public = editable in Unity, int =  whole number
    public int hazardDamage;
    
    
   //Built in Unity function for handling collisions
   //This function will be called when another object bumps
   //into the one this script is attached to
    void OnTriggerEnter2D(Collider2D collisionData)
    {
        //Get the object we collided with
        Collider2D objectWeCollidedWith = collisionData;

        //Get the PlayerHealth script attached to that object (if there is one)
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        //Check if we actually found a player health script on the object we collided with
        //This if statement is true if the player variable is NOT null (empty)
        if (player != null)
        {
            //This means there WAS a PlayerHealth script attached to the object we bumped into
            //Which means this object is indeed the player

            //Therefore perform our action
            player.ChangeHealth(-hazardDamage);
        }
    }

}
