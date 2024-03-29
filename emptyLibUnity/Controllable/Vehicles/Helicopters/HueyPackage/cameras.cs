﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *         .---.
 *         |[X]|
 *  _.==._.""""".___n__
 * d __ ___.-''-. _____b
 * |[__]  /."""".\ _   |
 * |     // /""\ \\_)  |
 * |     \\ \__/ //    |
 * |pentax\`.__.'/     |
 * \=======`-..-'======/
 *  `-----------------'  
 *  Switch 4 Cameras around the helicopter like quadtree 
 * 
 *@author Rolando<rgarro@gmail.com>
 */
public class cameras : MonoBehaviour
{

    public GameObject followingCamera;

    public GameObject frontCamera;

    public GameObject leftCamera;

    public GameObject rightCamera;
    protected bool follow_camera_is_hidden =  false;
    protected bool front_camera_is_hidden =  true;
    protected bool left_camera_is_hidden =  true;
    protected bool right_camera_is_hidden =  true;
   
     public int boxWidth = 265;
    public int boxHeight = 90;
    public int boxY = 10;
    public int buttonWidth = 40;
    public int buttonHeight = 40;
    public int buttonY = 40;
    public string boxLabel = "Cameras";

    public Texture2D FollowIcon;
    public Texture2D FrontIcon;
    public Texture2D LeftIcon;
    public Texture2D RightIcon;

    public GUISkin btnSkin;
    public int buttons_x_corner = 200;

    private AudioSource soundPlayer;
    public AudioClip cameraTransitionSoundClip;

    // Start is called before the first frame update
    void Start()
    {
         this.soundPlayer = GetComponent<AudioSource> ();
    }

    private void playTransitionSound(){
        this.soundPlayer.clip = this.cameraTransitionSoundClip;
        if (!this.soundPlayer.isPlaying) {
            this.soundPlayer.Play ();
        }
    }

    void OnGUI(){
        GUI.skin = this.btnSkin;
        GUI.Box(new Rect(this.buttons_x_corner,this.boxY,this.boxWidth,this.boxHeight), this.boxLabel);
          if(GUI.Button(new Rect(this.buttons_x_corner+55,this.buttonY,this.buttonWidth,this.buttonHeight), FollowIcon)) 
        {
            if(this.follow_camera_is_hidden){
                this.follow_camera_is_hidden = false;
                this.followingCamera.SetActive(true);
                //Debug.Log("Activating follow camera");
                this.frontCamera.SetActive(false);
                this.front_camera_is_hidden = true;
                this.rightCamera.SetActive(false);
                this.right_camera_is_hidden = true;
                this.leftCamera.SetActive(false);
                this.left_camera_is_hidden = true;
                this.playTransitionSound();
            } 
        }
        if(GUI.Button(new Rect(this.buttons_x_corner+110,this.buttonY,this.buttonWidth,this.buttonHeight), FrontIcon)){
            if(this.front_camera_is_hidden){
                this.front_camera_is_hidden = false;
                this.frontCamera.SetActive(true);
                //Debug.Log("Activating front camera");
                this.followingCamera.SetActive(false);
                this.follow_camera_is_hidden = true;
                this.rightCamera.SetActive(false);
                this.right_camera_is_hidden = true;
                this.leftCamera.SetActive(false);
                this.left_camera_is_hidden = true;
                this.playTransitionSound();
            } 
        }
        if(GUI.Button(new Rect(this.buttons_x_corner+160,this.buttonY,this.buttonWidth,this.buttonHeight), LeftIcon)){
            if(this.left_camera_is_hidden){
                this.left_camera_is_hidden = false;
                this.leftCamera.SetActive(true);
                this.front_camera_is_hidden = true;
                this.frontCamera.SetActive(false);
                //Debug.Log("Activating front camera");
                this.followingCamera.SetActive(false);
                this.follow_camera_is_hidden = true;
                this.rightCamera.SetActive(false);
                this.right_camera_is_hidden = true;  
                this.playTransitionSound();
            } 
        }

         if(GUI.Button(new Rect(this.buttons_x_corner+205,this.buttonY,this.buttonWidth,this.buttonHeight), RightIcon)){
            if(this.left_camera_is_hidden){
                this.rightCamera.SetActive(true);
                this.right_camera_is_hidden = false;
                this.left_camera_is_hidden = true;
                this.leftCamera.SetActive(false);
                this.front_camera_is_hidden = true;
                this.frontCamera.SetActive(false);
                //Debug.Log("Activating front camera");
                this.followingCamera.SetActive(false);
                this.follow_camera_is_hidden = true;  
                this.playTransitionSound();
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
