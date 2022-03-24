﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    // reference to the AudioClip we want to play on trigger enter.
    public AudioClip soundTrigger;
  
    public float dwell_time_threshold; // how many frames we need to detect before we trigger the sound

    private float dwell_time_tracker; // tracks the number of frames that the object has been inside of the collider


    /// OnTriggerStay is called almost every frame; https://docs.unity3d.com/ScriptReference/Collider.OnTriggerStay.html
    void OnTriggerStay(Collider other)
    {
        // at some point, I need to alter this if statement to take in foot plate markers only
        //if(other.name == "L-Frame O") 
        //{
        dwell_time_tracker += 1; // add to the tracker for every frame
    

            if (dwell_time_tracker == dwell_time_threshold)
            {

                // play the collect sound (at the same position as the target, 100% volume)
                AudioSource.PlayClipAtPoint(soundTrigger, transform.position, 1.0f);

            }
        //}
    }

    void OnTriggerExit(Collider other)
    {
        // at some point, I need to alter this if statement to take in foot plate markers only
        //if(other.name == "L-Frame O")
        //{
        dwell_time_tracker = 0;
         
        }
    }
}

