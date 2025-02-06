using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using emptyLibUnity.UI;
using emptyLibUnity.Controllable;//.Vehicles.Planes.F22;
//using System.Exception;
/**
 *             +
 *            /_\
 *  ,%%%______|O|
 *  %%%/_________\
 *  `%%| /\[][][]|%
 * ___||_||______|%&,__   November Rain , Slash solo ..
 *
 * Will detect round collitions on player and call .damageCountDown from tag in BatComputer
 * 
 *
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class friendRocketDetonator : MonoBehaviour
{
     public string enemyObjectTag = "maestroRoshi";
    public string scoreManagerTag = "BatComputer";
    public string inactiveCameraTag = "inactiveCam";
    public string activeCameraTag = "activeCam";
    public string bombContainerTag = "bolsaNinja";
    //private int downedTargetCount = 0;
    private GameObject damageCountdown;
    private GameObject bombsBag;
    private bool damageCountIsSet = false;
    private biCameraSwitcher biCameraSwitch;
    private bombContainer bombCont;
    public int ptsToIncrease = 10;
    //public bool isDamage = false;
     public GameObject laexplosion;
     //private GameObject inactiveCamera;
     //[SerializeField]
    private GameObject inactiveCamera;

     //[SerializeField]
     private GameObject activeCamera;
     public float windowX = 325;
    public float windowY = 30;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;
    public GUIStyle style;
    protected string theScore = "::: GAME OVER :::";
    private bool gameIsOver = false;


    // Start is called before the first frame update
    void Start()
    {
        //this.getDamageManager();
        //this.getInactiveCamera();
        //this.getActiveCamera();
    }

    void getDamageManager(){
        this.damageCountdown = GameObject.FindWithTag(this.scoreManagerTag);//Using BatComputer as Delegate to reach objects for prefabs nested multiple levels
        this.damageCountIsSet = true;
    }

    void getBombsContainer(){
        if(this.damageCountIsSet){
            this.bombCont = this.damageCountdown.GetComponent(typeof(bombContainer)) as bombContainer;
        }else{
            throw new Exception("getDamageCountdown before.");
        } 
    }

    void endOfGameLegend(){
        this.gameIsOver = true;
    }

    void getBiCameraSwitcher(){
        if(this.damageCountIsSet){
            this.biCameraSwitch = this.damageCountdown.GetComponent(typeof(biCameraSwitcher)) as biCameraSwitcher;
        }else{
            throw new Exception("getDamageCountdown before.");
        } 
    }

    void getActiveCamera(){
        //this.inactiveCamera = GameObject.Find("Camera");
        this.activeCamera = GameObject.FindGameObjectWithTag(this.activeCameraTag);
    }
    void getInactiveCamera(){
        //this.inactiveCamera = GameObject.Find("inactiveCamera");
        this.inactiveCamera = GameObject.FindGameObjectWithTag(this.inactiveCameraTag); 
    }

    public void increaseDamage(){
            damageCountdown tmpObj = this.damageCountdown.GetComponent(typeof(damageCountdown)) as damageCountdown;
            tmpObj.decreaseLife();
    }

    void tomeChichi(Collision collision){
        try
        {
            this.getDamageManager();
            this.getBiCameraSwitcher();
            this.getBombsContainer();
            //this.getInactiveCamera();//getByTag fails from prefabs instantiating prefabs
            //this.getActiveCamera();
            //this.inactiveCamera.SetActive(true);
            //this.activeCamera.SetActive(false);
            this.increaseDamage();
            //Debug.Log("explode instance ");
            GameObject ae = Instantiate(this.bombCont.f22HitByRocketExplode) as GameObject;//AE e oooo Ae oooo gole de saprissa !!!
            ae.transform.position = transform.position;//pasar explocion a final scene, piedrero olle gol de la S y toma trago de birra en el dragon chino
            
            this.biCameraSwitch.gun_camera.SetActive(true);
            this.biCameraSwitch.follow_camera.SetActive(false);
            
            Destroy(collision.gameObject);//God save the queen she aint a human been ...
            
            //this.endOfGameLegend(); 
        }
        catch (System.Exception e)
        {
            Debug.LogException(e, this);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == this.enemyObjectTag){
            this.tomeChichi(collision);
        }
    }

    void OnGUI(){
        if(this.gameIsOver){
            //Debug.Log("restart legend ... "); 
            this.windowRect = new Rect(this.windowX,this.windowY,this.windowHeight,this.windowWidth);		
		    GUI.Label(this.windowRect,this.theScore,this.style);
        }
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
