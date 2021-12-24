using System.Collections;
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
    public string scoreManagerTag = "BatComputer";//Andrea watching east on a december morning, blind south, regaeton murmur ...
    private GameObject scoreManager;
    public int ptsToIncrease = 10;

    // Start is called before the first frame update
    void Start()
    {
       this.getScoreManager();
    }

    void getScoreManager(){
        this.scoreManager = GameObject.FindWithTag(this.scoreManagerTag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore(){
         scoreDisplay tmpObj = this.scoreManager.GetComponent(typeof(scoreDisplay)) as scoreDisplay;
         tmpObj.addScore(this.ptsToIncrease);
         //Debug.Log(this.ptsToIncrease +" pts ...");
    }

    private void OnTriggerEnter2D(Collider2D other){
        //Debug.Log("Bulls eyes ..");
        GameObject e = Instantiate(this.explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        Destroy(this.gameObject);//fucking destroy
        this.increaseScore();
    }
}
