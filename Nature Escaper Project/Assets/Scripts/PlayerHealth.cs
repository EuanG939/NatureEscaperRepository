using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //This will be the starting health for the player
    //Public = shown in the Unity editor and accessible from other scripts
    //int = whole number
    public int startingHealth;
    public string gameOverScene;

    //This will be the player's current health
    //Changes as the game goes on
    int currentHealth;

    //Built in Unity function called when the script is created
    //Usually when the game starts
    //This happens before the start function
    void Awake()
    {
        //Initialise our current health to be equal to our starting health 
        //at the beginning of the game
        currentHealth = startingHealth;
    }

    //not built into Unity
    //must call it ourselves
    //changes player's current health and Kill() them if they have 0 health or less
    //public so other scripts can access it
    public void ChangeHealth(int changeAmount)
    {
        //Take current health, add change amount and store result back to the current health variable
        currentHealth = currentHealth + changeAmount;

        //keep our current health between 0 and starting health value
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        //if health drops to 0, means the player should die
        if (currentHealth <= 0)
        {
            //call kill fucntion to kill player
            Kill();
        }
    }


   //This function is not built into Unity
   //It will only be called manually by our own code
   //It must be marked public so our other scripts can access it
    public void Kill()
    {
        //This will destroy the gameobject that this script is attached to
        Destroy(gameObject);

        // Load the gameover scene
        SceneManager.LoadScene(gameOverScene);
    }

    public int GetHealth()
    {
        return currentHealth;
    }

}
