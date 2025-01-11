using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *             +
 *            /_\
 *  ,%%%______|O|
 *  %%%/_________\
 *  `%%| /\[][][]|%
 * ___||_||______|%&,__ hjw 
 *
 * will detect round collitions on player and increase player damage
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
    //private int downedTargetCount = 0;
    private GameObject damageCountdown;
    public int ptsToIncrease = 10;
    public bool isDamage = false;
     public GameObject explosion;
     private GameObject inactiveCamera;
    // Start is called before the first frame update
    void Start()
    {
        this.getDamageManager();
        this.getInactiveCamera();
    }

    void getDamageManager(){
        this.damageCountdown = GameObject.FindWithTag(this.scoreManagerTag);
    }

    void getInactiveCamera(){
        this.inactiveCamera = GameObject.FindWithTag(this.inactiveCameraTag);
    }

    public void increaseDamage(){
             damageCountdown tmpObj = this.damageCountdown.GetComponent(typeof(damageCountdown)) as damageCountdown;
             //Debug.Log("decrease pts ...");
            tmpObj.decreaseLife();
    }

    void tomeChichi(Collision collision){
        Debug.Log("fume mota y lea poesia : "+ collision.gameObject.tag);
        this.increaseDamage();
        GameObject e = Instantiate(this.explosion) as GameObject;
        e.transform.position = transform.position;
        //corregir error de camara aqui
        Destroy(collision.gameObject);//God save the queen she aint a human been ...
        this.inactiveCamera.SetActive(true);
        //Restart popup with legend 
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
