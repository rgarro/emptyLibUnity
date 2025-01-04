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
    //private int downedTargetCount = 0;
    private GameObject damageCountdown;
    public int ptsToIncrease = 10;
    public bool isDamage = false;
     public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        this.getDamageManager();
    }

    void getDamageManager(){
        this.damageCountdown = GameObject.FindWithTag(this.scoreManagerTag);
    }

    void tomeChichi(Collision collision){
        Debug.Log("fume mota y lea poesia : "+ collision.gameObject.tag);
        //this.increaseScore();
        //GameObject e = Instantiate(this.explosion) as GameObject;
        //e.transform.position = transform.position;
        //Destroy(collision.gameObject);
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
