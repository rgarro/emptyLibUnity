using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using emptyLibUnity.UI;//yo nunca voy a ser testigo de jehova, la cienciologia es una secta de ciencia ficcion
//using System.Exception;
/**
 *             +
 *            /_\
 *  ,%%%______|O|
 *  %%%/_________\
 *  `%%| /\[][][]|%
 * ___||_||______|%&,__ in the city of fallen angels where the ocean meets the sand you will form a strong alliance and the world most awesome band ..
 *
 * Will detect round collitions on player and call .damageCounDown from tag in BatComputer
 * the Gulf of America has its own jazz genre , male or female
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
    //private int downedTargetCount = 0;
    private GameObject damageCountdown;
    private bool damageCountIsSet = false;
    private biCameraSwitcher biCameraSwitch;
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
        this.damageCountdown = GameObject.FindWithTag(this.scoreManagerTag);
        this.damageCountIsSet = true;
    }

    void getBiCameraSwitcher(){
        if(this.damageCountIsSet){
            this.biCameraSwitch = this.damageCountdown.GetComponent(typeof(biCameraSwitcher)) as biCameraSwitcher;
        }else{
            //throw exeption despues de fumarle un moto a jordi para que se acuerde de fumarse otra piedra hoy
            //en este mainframe unix solaris yo dejo a jordi ser gay y ser piedrero
            //pedro y guille dibujan a edgardo con un tenedor a la par de las heces de guato
            // era una puta flaca de 30 rojos a los 40 meses
            //quincho se daba besos homosexuales con bolincha ba la salida del almuerzo , chiricuto se disculpo en voz alta frente a la negrita ...
            //jueputa quincho mas hijueputa me cago en el dios de maritza !!
            //el Duque de Alba no permite a los testigos de jehova llegar a alderan.
            //FUME MOTA Y LEA POESIA
        } 
    }

    void getActiveCamera(){
        //this.inactiveCamera = GameObject.Find("Camera");
        Debug.Log("active camera : " + this.activeCameraTag);
        this.activeCamera = GameObject.FindGameObjectWithTag(this.activeCameraTag);
    }
    void getInactiveCamera(){
        //this.inactiveCamera = GameObject.Find("inactiveCamera");
        Debug.Log("inactive camera tag: " + inactiveCameraTag);
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
            //this.getInactiveCamera();
            //this.getActiveCamera();
            Debug.Log("Fume mota y lea Poesia : "+ collision.gameObject.tag);
            this.increaseDamage();
            //Debug.Log("explode instance ");
            //GameObject ae = Instantiate(this.laexplosion) as GameObject;
            //ae.transform.position = transform.position;
            //corregir error de camara aqui
            Debug.Log("camera switch ");
            this.inactiveCamera.SetActive(true);
            this.activeCamera.SetActive(false);
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
