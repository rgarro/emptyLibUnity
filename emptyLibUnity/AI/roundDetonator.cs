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
    public string scoreManagerTag = "BatComputer";
    //private GameObject scoreManager;

    // Start is called before the first frame update
    void Start()
    {
       //this.scoreManager = GameObject.FindWithTag(this.scoreManagerTag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void increaseScore(){
        //this.scoreManager.addScore(10);
        //this.scoreManager.GetComponent<addScore>(10);
    }

    private void OnTriggerEnter2D(Collider2D other){
        //Debug.Log("Bulls eyes ..");
        GameObject e = Instantiate(this.explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        Destroy(this.gameObject);//fucking destroy
    }
}
