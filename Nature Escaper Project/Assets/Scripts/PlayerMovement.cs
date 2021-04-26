using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //public variables, visible in Unity inspector
    public float forceStrength;

    //variable to hold thr audio clip that should play when we walk
    public AudioClip footstepSound;

    //called once per frame
    public void Update()
    {
        // Get the rigidbody from our player so we can check its speed
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Find out from the rigidbody what our current horizontal and vertical speeds are
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        // Get the animator that we'll be using for movement
        Animator ourAnimator = GetComponent<Animator>();

        // Tell our animator what the speeds are
        ourAnimator.SetFloat("speedH", currentSpeedH);
       

    }

    //These will be called by each button for movement
    public void MoveLeft()
    {
        //get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set forceStrength
        ourRigidbody.AddForce(Vector2.left * forceStrength);

        //Get the audio source so we can play footstep sounds
        AudioSource ourAudioSource = GetComponent<AudioSource>();

        //Check if our clip is already playing
        if (ourAudioSource.clip == footstepSound && ourAudioSource.isPlaying)
        {
            //Do nothing - our audio source is already playing the sound effect we want
        }
        else
        {
            ourAudioSource.clip = footstepSound;
            ourAudioSource.Play();
        }

    }
    public void MoveRight()
    {
        //get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set forceStrength
        ourRigidbody.AddForce(Vector2.right * forceStrength);

        //Get the audio source so we can play footstep sounds
        AudioSource ourAudioSource = GetComponent<AudioSource>();

        //Check if our clip is already playing
        if (ourAudioSource.clip == footstepSound && ourAudioSource.isPlaying)
        {
            //Do nothing - our audio source is already playing the sound effect we want
        }
        else
        {
            ourAudioSource.clip = footstepSound;
            ourAudioSource.Play();
        }

    }
   

}
