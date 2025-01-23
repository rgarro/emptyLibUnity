using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using emptyLibUnity.UI;
using emptyLibUnity.Controllable.Vehicles.Planes.F22;
//using System.Exception;
/**
 *             +
 *            /_\
 *  ,%%%______|O|
 *  %%%/_________\
 *  `%%| /\[][][]|%
 * ___||_||______|%&,__ November Rain , Slash solo ..
 *
 * Will detect round collitions on player and call .damageCounDown from tag in BatComputer
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
            //FUME MOTA Y LEA POESIA
        } 
    }

    void getBiCameraSwitcher(){
        if(this.damageCountIsSet){
            this.biCameraSwitch = this.damageCountdown.GetComponent(typeof(biCameraSwitcher)) as biCameraSwitcher;
        }else{
            throw new Exception("getDamageCountdown before.");
            //FUME MOTA Y LEA POESIA
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
             //Debug.Log("decrease pts ...");
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
            Debug.Log("camera switch ");
            this.biCameraSwitch.gun_camera.SetActive(true);
            this.biCameraSwitch.follow_camera.SetActive(false);
            Debug.Log("Fume Mota y lea Poesia : "+ collision.gameObject.tag);
            this.increaseDamage();
            Debug.Log("explode instance ");
            GameObject ae = Instantiate(this.bombCont.f22HitByRocketExplode) as GameObject;
            ae.transform.position = transform.position;
            Destroy(collision.gameObject);//God save the queen she aint a human been ...
            //Restart popup with legend 
            Debug.Log("where do we go from here ... ");  
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
