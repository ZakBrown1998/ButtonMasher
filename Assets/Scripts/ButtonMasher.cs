using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

//Data for our class
    public AudioSource clickSound; //sound that will play when we click the button
    public AudioSource gameoverSound; //sound that will play when time has run out
    public AudioSource startSound; //Sound that plays when the game starts
    public TextMesh timerText; //Displays text for the timer
    public TextMesh scoreText; //Display text for the player's score
    public TextMesh messageText; //displays a message when the game ends
    public float gameLength; //How many seconds will the game last 

    private int score = 0; //the numerical data value of our score
    private float timeRemaining = 0; //Numerical time remaining for game
    private bool gameRunning = false;

    // Use this for initialization
    void Start() {
        Debug.Log("Start method called");


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
            if (gameRunning == true)
            { //Play the game over sounds
                gameoverSound.Play();

                messageText.text = "Time up! Final Score = " + score.ToString();
            }
            gameRunning = false;

            timeRemaining = 0;
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

        else
        {
            //game is not running
            gameRunning = true;

            timeRemaining = gameLength;

            messageText.text = "mash the button!";

            //Reset the score
            score = 0;

            //Update visual score
            scoreText.text = score.ToString();

            //Play start  game sound 
            startSound.Play();
        }

    }//End of OnMouseDown


}//End of ButtonMasher class

