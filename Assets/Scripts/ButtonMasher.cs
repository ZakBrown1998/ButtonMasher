using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

//Data for our class
    public AudioSource clickSound; //sound that will play when we click the button
    public TextMesh timerText; //Displays text for the timer
    public TextMesh scoreText; //Display text for the player's score
    public float gameLength; //How many seconds will the game last 

    private int score = 0; //the numerical data value of our score
    private float timeRemaining = 0; //Numerical time remaining for game
    private bool gameRunning = true;

    // Use this for initialization
    void Start() {
        Debug.Log("Start method called");

        timeRemaining = gameLength;

    } //End of Start()

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method called");

        timeRemaining = timeRemaining - Time.deltaTime;

        //Update the visual time remaining
        timerText.text = (Mathf.CeilToInt (timeRemaining)).ToString();

        if (timeRemaining <= 0)
        {

            timeRemaining = 0;
            gameRunning = false;
        } //End of if 
    } //End of Update()

    
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        //Check if the game is still running 
        if (gameRunning == true)
        {
            clickSound.Play();
            //Trigger our clicking sound to play
            //Increase the score by 1
            score = score + 1;
            //Update visual score
            scoreText.text = score.ToString();
        } // End of if (gameRunning == true)

    }//End of OnMouseDown


}//End of ButtonMasher class

