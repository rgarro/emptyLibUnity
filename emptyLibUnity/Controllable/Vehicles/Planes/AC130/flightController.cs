//using System.Reflection.PortableExecutable;
using System.Diagnostics;
//using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using emptyLibUnity.UI.Util;
using UnityEngine.UI;
/**
 * The Dharmakaya of my Slingshot Mixer Surfboard
 * :: AC130  Helimover ::
 *           _\ _~-\___
 *   =  = ==(____AA____D
 *               \_____\___________________,-~~~~~~~`-.._
 *               /     o O o o o o O O o o o o o o O o  |\_
 *               `~-.__        ___..----..                  )
 *                     `---~~\___________/------------`````
 *                     =  ===(_________D
 * ::: Producing my Slingshot Turbine Surfkite :::
 *  the wind is 11knots east, 
 *
 *
 *
 *@author Rolando<rolando@emptyart.xyz> 
 */
public class flightController : MonoBehaviour
{

    public GameObject heliPad;
    public GameObject heliPad2;
    public GameObject heliPad3;
    public GameObject heliPad4;
    public GameObject AirPlane;
    public float rotationSteps = 0.87f;
    public bool turnClocwise = true;
    private float helipadRotationX;
    public float yardsPerSecond = 2.0f;
    //public float engineY = 0;
    //public float engineZ = 0;
    private AudioSource soundPlayer;
    public AudioClip AirPlaneEngineSoundClip;
     public int enginePowerSliderYpos = 25;
    public int enginePowerSliderXpos = 25;
    public string engineThrottleLabel = "Engine Power";
    public float diveCurveAngleZ = 1.00f;
    public float sideDiveAccelerationRate = 2.00f;
    public float minAltitude = 3.38f;
    public float maxAltitude = 15.35f;
    public float elevationSteps = 0.05f;
    private bool isDived = false;
//    private bool isDivedr = false;
    private bool isElevated = false;
    private bool isdElevated = false;
    public float elevationCurveAngleX = 3.25f;
    public float descendingCurveAngleX = -3.25f;
    public float elevationStep = 0.2f;
    public float maxZBoundaryPos = 10.2f;
    public float returnZpos = 900.1f;

    private SimpleGaugeNeedle speedNeedle;
    public Image NeedleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //this.anim = GetComponent<Animator>();
        this.helipadRotationX = this.heliPad.transform.rotation.x;

        //Engine Sound
        this.soundPlayer = GetComponent<AudioSource> ();
        this.soundPlayer.volume = 0.2F;
        this.playEngineSound();
        this.startDashItems();
    }

    void startDashItems(){
        this.speedNeedle = new SimpleGaugeNeedle();
        //this.speedNeedle = this.AddComponent(typeof(SimpleGaugeNeedle)) as SimpleGaugeNeedle;
        this.speedNeedle.Needle = this.NeedleSpeed;
    }

       void setSpeedNeedle(){
		this.speedNeedle.getTilter(this.yardsPerSecond);
		this.speedNeedle.tiltNeedle();
	}

    // Update is called once per frame
    void Update()
    {
       this.rotateHelipad();
       this.moveForward();
       this.joystickControls();
       this.reachZBoundaryBack();
       this.setSpeedNeedle();
    }

    private void rotateHelipad(){
		//this.playEngineSound();
        if(this.helipadRotationX < 359){
            this.helipadRotationX += this.rotationSteps;
        }else{
            this.helipadRotationX = 1;
        }
         this.helipadRotationX += this.rotationSteps;
		this.heliPad.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad2.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad3.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad4.transform.Rotate(0,this.helipadRotationX,0);
	}

    void OnGUI(){
        GUI.Box(new Rect(this.enginePowerSliderXpos - 20,this.enginePowerSliderYpos - 15,275,30), this.engineThrottleLabel);
        this.yardsPerSecond = GUI.HorizontalSlider(new Rect(this.enginePowerSliderXpos, this.enginePowerSliderYpos, 250, 50), this.yardsPerSecond, 2.0F, 10.0F);
    }

    void playEngineSound(){
         this.soundPlayer.clip = this.AirPlaneEngineSoundClip;
        if (!this.soundPlayer.isPlaying) {
            this.soundPlayer.Play ();
        }
    }


    void diveLeft(){
        this.AirPlane.transform.Translate(Vector3.right * Time.deltaTime* (this.yardsPerSecond/this.sideDiveAccelerationRate));
        if(!this.isDived){
            this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ*-1);
            this.isDived = true;
        }
    }

    void diveRight(){
        this.AirPlane.transform.Translate(Vector3.left * Time.deltaTime* (this.yardsPerSecond/this.sideDiveAccelerationRate));
        if(!this.isDived){
            this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ);
            this.isDived = true;
        }
    }
    void increaseEleveation(){
        if(this.AirPlane.transform.position.y < this.maxAltitude && this.AirPlane.transform.position.y > this.minAltitude){
            this.AirPlane.transform.Translate(Vector3.up * (Time.deltaTime * this.yardsPerSecond));
            if(!this.isElevated){
                this.AirPlane.transform.Rotate(this.elevationCurveAngleX,0,0);
                this.isElevated = true;
                //Stepping
                /*if(this.AirPlane.transform.rotation.x < this.elevationCurveAngleX){
                    float nextElevationAngle = this.AirPlane.transform.rotation.x + this.elevationStep;
                    //this.AirPlane.transform.Rotate(this.elevationCurveAngleX,0,0);
                    this.AirPlane.transform.Rotate(nextElevationAngle,0,0);
                }else{      
                    this.isElevated = true;
                } */   
            }
        }
    }

    void decreaseElevation(){
        if(this.AirPlane.transform.position.y < this.maxAltitude && this.AirPlane.transform.position.y > this.minAltitude){
            this.AirPlane.transform.Translate(Vector3.down * (Time.deltaTime * this.yardsPerSecond));
            if(!this.isdElevated){
                this.AirPlane.transform.Rotate(this.descendingCurveAngleX,0,0);//step this later
                this.isdElevated = true;
            }
        }
    }

    void moveForward(){
        this.AirPlane.transform.Translate(Vector3.back * (Time.deltaTime * this.yardsPerSecond));
    }

    void stabilizePlane(){
        this.AirPlane.transform.Rotate(0,0,0);
        this.isDived = false;
    }

    void reachZBoundaryBack(){
        if(this.AirPlane.transform.position.z < this.maxZBoundaryPos){
            this.AirPlane.transform.Translate(new Vector3(this.AirPlane.transform.position.x,this.AirPlane.transform.position.y,this.returnZpos));
        }
    }

    void doRestart(){
       
    }

    void joystickControls(){
        if (Input.GetKey("up"))
        {
            this.increaseEleveation();
        }

        if (Input.GetKey("down"))
        {
            this.decreaseElevation();
        }
         if (Input.GetKey("left")){
             this.diveLeft();
         }
        if (Input.GetKey("right")){
            this.diveRight();
         }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.doRestart();
        }

        /*if (Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            this.stabilizePlane();
        }*/

        if (Input.GetKeyUp("left"))
        {
            if(this.isDived){
                this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ);
                this.isDived = false;
            }
        }

        if (Input.GetKeyUp("right"))
        {
            if(this.isDived){
                this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ*-1);
                this.isDived = false;
            }
        }

         if (Input.GetKeyUp("up"))
        {
            if(this.isElevated){
                this.AirPlane.transform.Rotate(this.elevationCurveAngleX*-1,0,0);//step return tomorrow
                this.isElevated = false;
            }
        }
        if (Input.GetKeyUp("down"))
        {
            if(this.isdElevated){
                this.AirPlane.transform.Rotate(this.descendingCurveAngleX*-1,0,0);
                this.isdElevated = false;
            }
    
        }

    }
}