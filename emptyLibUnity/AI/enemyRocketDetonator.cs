//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *                                 o o
 *                                 o ooo
 *                                   o oo
 *                                      o o      |   #)
 *                                       oo     _|_|_#_    - Fucking Destroy Punk Rock is about Math   -
 *                                         o   | 751   |
 *    __                    ___________________|       |_________________
 *   |   -_______-----------                                              \
 *  >|    _____                                                   --->     )
 *   |__ -     ---------_________________________________________________ /
 *
 * onCollide enemy rockets will subtract life points to collided and trigger explosion object
 *
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class enemyRocketDetonator : MonoBehaviour
{

    public string enemyObjectTag = "superSaiyan";
    public string scoreManagerTag = "BatComputer";
    //private int downedTargetCount = 0;
    private GameObject scoreUpdater;
    private GameObject damageCountdown;
    public int ptsToIncrease = 10;
    public bool isDamage = false;
     public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        this.getScoreManager();
    }

    void getScoreManager(){
        //if(this.isDamage){
           // this.damageCountdown = GameObject.FindWithTag(this.scoreManagerTag);
        //}else{
            this.scoreUpdater = GameObject.FindWithTag(this.scoreManagerTag);
        //}
        
    }

    public void increaseScore(){
            scoreDisplay tmpObj = this.scoreUpdater.GetComponent(typeof(scoreDisplay)) as scoreDisplay;
            tmpObj.addScore(this.ptsToIncrease);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void tomeChichi(Collision collision){
        Debug.Log("Tome Chichi : "+ collision.gameObject.tag);
        this.increaseScore();
        GameObject e = Instantiate(this.explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(collision.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == this.enemyObjectTag){
            this.tomeChichi(collision);
        }
    }
}
