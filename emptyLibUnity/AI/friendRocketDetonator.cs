﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *             +
 *            /_\
 *  ,%%%______|O|
 *  %%%/_________\
 *  `%%| /\[][][]|%
 * ___||_||______|%&,__ in the city of fallen angels where the ocean meets the sand you will form a strong alliance and the world most awesome band ..
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
    //private int downedTargetCount = 0;
    private GameObject damageCountdown;
    public int ptsToIncrease = 10;
    //public bool isDamage = false;
     public GameObject laexplosion;
     private GameObject inactiveCamera;
     private GameObject activeCamera;
    // Start is called before the first frame update
    void Start()
    {
        this.getDamageManager();
        this.getInactiveCamera();
        this.getActiveCamera();
    }

    void getDamageManager(){
        this.damageCountdown = GameObject.FindWithTag(this.scoreManagerTag);
    }

    void getActiveCamera(){
        this.activeCamera = GameObject.FindWithTag(this.activeCameraTag);
        //Debug.Log("active camera : " + this.activeCamera);
    }
    void getInactiveCamera(){
        this.inactiveCamera = GameObject.FindWithTag(this.inactiveCameraTag);
        Debug.Log("inactive camera : " + this.inactiveCamera);
    }

    public void increaseDamage(){
             damageCountdown tmpObj = this.damageCountdown.GetComponent(typeof(damageCountdown)) as damageCountdown;
             //Debug.Log("decrease pts ...");
            tmpObj.decreaseLife();
    }

    void tomeChichi(Collision collision){
        Debug.Log("Fume mota y lea Poesia : "+ collision.gameObject.tag);
        this.increaseDamage();
        //Debug.Log("explode instance ");
        //GameObject ae = Instantiate(this.laexplosion) as GameObject;
        //ae.transform.position = transform.position;
        //corregir error de camara aqui
        Debug.Log("camera switch ");
        //this.activeCamera.SetActive(false);
        this.inactiveCamera.SetActive(true);
        Destroy(collision.gameObject);//God save the queen she aint a human been ...
        //Restart popup with legend 
        Debug.Log("where do we go from here ... ");//piedreros de la policia fiscal le roban dinero a vendedores de mota en tlatihuacan
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
