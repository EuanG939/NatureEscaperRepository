using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public variable
    public Text scoreDisplay;
    
    //private variables
    private int scoreValue = 0;
    
    //function to add player's score
    //not automatically called by unity, we need to call it ourselves in our code
    public void AddScore(int toAdd)
    {
        //update the numerical value of the score (action 1)
        scoreValue = scoreValue + toAdd;

        //update display of score based on numerical value
        scoreDisplay.text = scoreValue.ToString();
    }
}
