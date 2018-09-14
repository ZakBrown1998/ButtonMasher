using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

//Data for our class
    public AudioSource clickSound; //sound that will play when we click the button

    // Use this for initialization
    void Start() {
        Debug.Log("Start method called");
    } //End of Start()

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method called");
    } //End of Update()

    
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        clickSound.Play();
        //Trigger our clicking sound to play

    }//End of OnMouseDown


}//End of ButtonMasher class

