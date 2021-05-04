using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    //This will contain a list of the game objects for the health icons
    //[] this will be an array (list)
    //GameObject = this list will contain GameObjects
    public GameObject[] healthIcons;

    //contains playerhealth component, so we can ask it for info about player's health
    PlayerHealth player;

    
    // Start is called before the first frame update
    void Start()
    {
        //we search the scene for the object with the playerhealth attached
        //store the playerhealth component from that object in our player variable
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create variable that keeps track of which item in the list we are on and how much health that icon is worth
        int iconHealth = 0;

        //go through each icon in list and do everything inside bracket for each item in list
        //for each step in the loop, we store the current list item in the icon variable
        foreach (GameObject icon in healthIcons)
        {
            iconHealth = iconHealth + 1;

            //if player's health is equal or greater than the health value for this icon
            if (player.GetHealth() >= iconHealth)
            {
                //turn icon on
                icon.SetActive(true);
            }
            else
            {
                //otherwise (the player's health is less than this icon's value)
                //turn icon off
                icon.SetActive(false);
            }

        }
    }
}
