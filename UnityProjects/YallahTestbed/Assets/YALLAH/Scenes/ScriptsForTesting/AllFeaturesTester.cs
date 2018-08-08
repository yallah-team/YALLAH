﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[RequireComponent(typeof(EyeHeadGazeController))]
public class AllFeaturesTester : MonoBehaviour {


    [Tooltip("Please, drag here the avatar parent of this mesh")]
    public GameObject avatar;


    [Header("Gaze:")]
    [Tooltip("The character will stare at this Game Object.")]
	public GameObject gazeTarget;
    [Tooltip("The gaze target will orbit around the head of the character.")]
	public bool animateGazeTarget = false;
    private EyeHeadGazeController gazescript;


    [Header("Text-to-Speech:")]
    [Tooltip("The character will say something every x seconds")]
    public float speakIntervalSecs = 5.0f;
    private MaryTTSController ttsController;
	private float lastSpeakStart = 0.0f;

    [Header("Locomotion:")]
    [Tooltip("The will randomly walk somewhere every x seconds")]
    public float walkIntervalSecs = 10.0f;
    private LocomotionController locomotionController;
    private float lastWalkStart = 0.0f;


    // Use this for initialization
    void Start()
    {
        if (this.avatar == null)
        {
            Debug.LogError("The 'avatar' has not been specified");
            Debug.Break();
        }

        this.gazescript = gameObject.GetComponent<EyeHeadGazeController>();
        this.ttsController = gameObject.GetComponent<MaryTTSController>();
        this.locomotionController = this.avatar.GetComponent<LocomotionController>();
    }


	// Update is called once per frame
	void Update() {
		float now = Time.time ;

		//
		// Move Eye gaze target
		if (this.animateGazeTarget) {
            // Sinusoidal orbit around the character's head.
			Vector3 gaze_position = new Vector3 (Mathf.Sin (now * 2.0f) * 1.0f,
                                                 1.5f + Mathf.Sin (now * 3.0f) * 1.0f,
                                                 Mathf.Sin (now * 4.0f) * 0.7f);
            gaze_position += gameObject.transform.position;
			// print ("Looking at " + gaze_position);
			this.gazeTarget.transform.position = gaze_position;
		}
        // Look at the target
		this.gazescript.LookAtPoint(this.gazeTarget.transform.position);

		//
		// Repeat a sentence
		if(now - this.lastSpeakStart > this.speakIntervalSecs)
        {
			this.ttsController.MaryTTSspeak ("The quick brown fox jumps over the lazy dog.");
			this.lastSpeakStart = now;
		}

        //
        // Walk here and there
        if(now - this.lastWalkStart > this.walkIntervalSecs)
        {
            Vector3 target_position = new Vector3(UnityEngine.Random.Range(-4, 4),
                                                  0.0f,
                                                  UnityEngine.Random.Range(-4, 4));
            Debug.Log("Walking to " + target_position);
            this.locomotionController.WalkTo(target_position);
            this.lastWalkStart = now;
        }

	}
	
}
