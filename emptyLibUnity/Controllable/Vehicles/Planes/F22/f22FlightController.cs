﻿using System.Diagnostics;
//using System.Reflection.PortableExecutable;
using System.Threading;
//using System.Diagnostics;
using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using emptyLibUnity.UI.Util;
using UnityEngine.UI;
using UnityEngine;
/**
 * ______
 *  L,.   ',
 *   \      ',_
 *    \   @   ',
 *     \ ^~^    ',
 *      \ ADOBE   ',
 *       \___Fireworks',_                        _..----.._
 *       [______       "'==.I\_____________..--"<__\\_n@___4\,_
 *     ,..-=T      __ GOL____________ DE__SAPRISSA \/  "'" O<==  ""-+.._
 *     I____|_____    }_>=========I>=**""''==-------------==-   " |   "'-.,___
 *     [_____,.--'"             _______         ""--=<""-----=====+==--''""
 *     ""'-=+..,,__,-----,_____|       |         -=* |
 *                 |__   /     |---,--'"---+------+-'"
 *                    """     d"b="        '-----+t
 *                            q_p                '@
 * The Game to appear Kitesurfing in Jaco ...
 * Maicol Jordan es un hijueputa !!
 * 
 * 
 *
 *
 *@author Rolando<rolando@emptyart.xyz>
 */
public class f22FlightController : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    public GameObject AirPlane;
    public GameObject Cockpit;
    private AudioSource soundPlayer;
    public AudioClip AirPlaneEngineSoundClip;
    public float minAltitude = 3.39f;
    public float maxAltitude = 14.35f;
    public float yardsPerSecond = 2.0f;
    public float sideDiveAccelerationRate = 2.00f;
    private bool isDived = false;

    private bool isLeftDived = false;
    private bool isRightDived = false;

    public int enginePowerSliderYpos = 25;
    public int enginePowerSliderXpos = 25;
    public string engineThrottleLabel = "Engine Power";
    public float diveCurveAngleZ = 1.00f;
    public float diveAngleLeft = 1.00f;
    public float diveAngleRight = 1.00f;

    public bool cockpit_is_closed = false;
    //private bool isDivedr = false;
    private bool isElevated = false;
    //private bool isdElevated = false;
    public float elevationCurveAngleX = 3.25f;
    public float descendingCurveAngleX = -3.25f;
    public float elevationStep = 0.2f;
    public float maxZBoundaryPos = 10.2f;
    public float returnZpos = 900.1f;
    public float maxYardsPerSecond = 70.1f;
    public float initYardsPerSecond = 2.1f;
    public float degreesToCloseCokpit = 15.1f;
    public float degreesToOpenCokpit = 15.1f;
    private SimpleGaugeNeedle speedNeedle;
    public Image NeedleSpeed;

    private SimpleGaugeNeedle altitudeNeedle;
    public Image NeedleAltitude;

    public Texture2D closeCockpitIcon;
    public float IconX = 10;
    public float IconY = 10;
    public float IconWidth = 128;
    public float IconHeight = 128;
    public float windowX = 20;
    public float windowY = 20;
    public float windowWidth = 300;
    public float windowHeight = 300;
    private Rect windowRect; 


    // Start is called before the first frame update
    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource> ();
        this.soundPlayer.volume = 0.2F;
        this.windowRect = new Rect(this.windowX, this.windowY, this.windowWidth,this.windowHeight);
        this.startDashItems();
    }

    void startDashItems(){
        this.speedNeedle = new SimpleGaugeNeedle();
        //this.speedNeedle = this.AddComponent(typeof(SimpleGaugeNeedle)) as SimpleGaugeNeedle;
        this.speedNeedle.Needle = this.NeedleSpeed;
        this.altitudeNeedle = new SimpleGaugeNeedle();
        this.altitudeNeedle.Needle = this.NeedleAltitude;
    }

    void setSpeedNeedle(){
		this.speedNeedle.getTilter(this.yardsPerSecond);
		this.speedNeedle.tiltNeedle();
	}

    void setAltitudeNeedle(){
		this.altitudeNeedle.getTilter(this.AirPlane.transform.position.y);
		this.altitudeNeedle.tiltNeedle();
	}

    // Update is called once per frame
    void Update()
    {
        this.joystickControls();
        this.moveForward();
         this.setSpeedNeedle();
    }

    
    void closeCockpit(){
        if(!this.cockpit_is_closed){
            this.Cockpit.transform.Rotate(0,0,this.degreesToCloseCokpit);
            this.cockpit_is_closed = true;
        }
    }

    void openCockpit(){
        if(this.cockpit_is_closed){
            this.Cockpit.transform.Rotate(0,0,this.degreesToOpenCokpit);
            this.cockpit_is_closed = false;
        }
    }

     void moveForward(){
        //Debug.Log("moving forward ...");
        this.AirPlane.transform.Translate(Vector3.forward * (Time.deltaTime * this.yardsPerSecond));
    }

    //must elevate with arrow button
    void descend(){
        this.stabilize();
        if(this.AirPlane.transform.position.y > this.minAltitude){
            this.AirPlane.transform.Translate(Vector3.down * (Time.deltaTime * this.yardsPerSecond));
        }
    }

    //must descend with arrow button
    void elevate(){
        this.stabilize();
        if(this.AirPlane.transform.position.y < this.maxAltitude){
            this.AirPlane.transform.Translate(Vector3.up * (Time.deltaTime * this.yardsPerSecond));
        }
    }

    void stabilize(){
        this.AirPlane.transform.Rotate(0,0,0);
        this.isLeftDived = false;
        this.isRightDived = false;
    }

    void diveLeft(){
        Debug.Log(" Diving Left ....");
        this.isRightDived = false;
        this.AirPlane.transform.Translate(Vector3.left * Time.deltaTime* (this.yardsPerSecond/this.sideDiveAccelerationRate));                
        if(!this.isLeftDived){
            this.AirPlane.transform.Rotate(0,0,diveAngleLeft);
            this.isLeftDived = true;
        }
    }

    void diveRight(){
        this.isLeftDived = false;
        this.AirPlane.transform.Translate(Vector3.right * Time.deltaTime* (this.yardsPerSecond/this.sideDiveAccelerationRate));
        if(!this.isRightDived){
            this.AirPlane.transform.Rotate(0,0,diveAngleRight);    
            this.isRightDived = true;
            Debug.Log("Is right dived..");
        }
    }

    void increaseSpeed(){

    }

    void decreaseSpeed(){
        
    }

     void OnGUI(){
        GUI.Box(new Rect(this.enginePowerSliderXpos - 20,this.enginePowerSliderYpos - 15,275,30), this.engineThrottleLabel);
        this.yardsPerSecond = GUI.HorizontalSlider(new Rect(this.enginePowerSliderXpos, this.enginePowerSliderYpos, 250, 50), this.yardsPerSecond, this.initYardsPerSecond, this.maxYardsPerSecond);
         if(GUI.Button(new Rect (this.IconX,this.IconY,this.IconWidth,this.IconHeight),this.closeCockpitIcon)) 
        {
            //Debug.Log("you clicked the icon");
        }
    }

    void joystickControls(){
        if (Input.GetKey("down"))
        {
            this.descend();
        }
        if (Input.GetKey("up"))
        {
            this.elevate();
        }
        if (Input.GetKey("left"))
        {
            if(this.isRightDived){
                this.stabilize();
            }
            this.diveLeft();
        }
        if (Input.GetKey("right"))
        {
            if(this.isLeftDived){
                this.stabilize();
            }
            this.diveRight();
        }
        if (Input.GetKey("a"))
        {
            this.increaseSpeed();
        }
         if (Input.GetKey("z"))
        {
            this.decreaseSpeed();
        }
    }
}
