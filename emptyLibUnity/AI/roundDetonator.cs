﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *     _.-^^---....,,--       
 * _--                  --_  
 *<                        >)
 *|                         | 
 * \._                   _./  
 *    ```--. . , ; .--'''       
 *          | |   |             
 *       .-=||  | |=-.   
 *       `-=#$%&%$#=-'   
 *          | ;  :|     
 * _____.,-#%&$@%#&#~,._____
 *
 * === Will remove collided and trigger blast or visual effect ===
 *   includes score counter
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class roundDetonator : MonoBehaviour
{

    public GameObject explosion;
    public GameObject roundHit;
    public string scoreManagerTag = "BatComputer";
    private GameObject scoreUpdater;
    private GameObject damageCountdown;
    public int ptsToIncrease = 10;
    public bool isDamage = false;

    // Start is called before the first frame update
    void Start()
    {
       this.getScoreManager();
    }

    void getScoreManager(){
        if(this.isDamage){
            this.damageCountdown = GameObject.FindWithTag(this.scoreManagerTag);
        }else{
            this.scoreUpdater = GameObject.FindWithTag(this.scoreManagerTag);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore(){
         if(this.isDamage){
             damageCountdown tmpObj = this.damageCountdown.GetComponent(typeof(damageCountdown)) as damageCountdown;
            tmpObj.decreaseLife();
        }else{
            scoreDisplay tmpObj = this.scoreUpdater.GetComponent(typeof(scoreDisplay)) as scoreDisplay;
            tmpObj.addScore(this.ptsToIncrease);
            //Debug.Log(this.ptsToIncrease +" pts ...");
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(this.isDamage){
            Debug.Log("Checking Damage ..");
            if (other.gameObject.CompareTag(this.scoreManagerTag)){
            Debug.Log("The Other ..");    
                this.increaseScore();
            damageCountdown tmpObj = this.damageCountdown.GetComponent(typeof(damageCountdown)) as damageCountdown;
            if(tmpObj.remainingLife < 0){
                 GameObject e = Instantiate(this.explosion) as GameObject;
                e.transform.position = transform.position;
                Destroy(other.gameObject);
                Destroy(this.gameObject);//fucking destroy
                //POPUP RESTART HERE
                    //post username and points to firebase
                    //get top ten scores
                    //legend pointing to restart
            }else{
                GameObject e = Instantiate(this.roundHit) as GameObject;
                e.transform.position = other.gameObject.transform.position;
                Destroy(this.gameObject);//fucking destroy
            }
            }
        }else{
             GameObject e = Instantiate(this.explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);//fucking destroy
            this.increaseScore();
        }
        
    }

}
