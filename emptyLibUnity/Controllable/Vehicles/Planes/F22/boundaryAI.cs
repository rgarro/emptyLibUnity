using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *                     `. ___
 *                    __,' __`.                _..----....____
 *        __...--.'``;.   ,.   ;``--..__     .'    ,-._    _.-'
 *  _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'
 *,'________________                          \`-._`-','
 * `._              ```````````------...___   '-.._'-:
 *    ```--.._      ,.                     ````--...__\-.
 *            `.--. `-`                       ____    |  |`
 *              `. `.                       ,'`````.  ;  ;`
 *                `._`.        __________   `.      \'__/`
 *                   `-:._____/______/___/____`.     \  `
 *                               |       `._    `.    \
 *                               `._________`-.   `.   `.___
 *                                                  `------'`
 * 
 * King Mosiah ordered Alma the highest priest yea
 * to expell all the lamanites possing as jahova witnesess from the land of Zarahemla yea
 * king Mosiah warriors slained them all near by the turtle creek road 
 * the king sent the orders from a piece remainder from the original lord Nephi's spaceship Amen ...
 *
 *  BE AWARE :
 *
 * this script will keep away lamanites away from your businnes but ,lucifer the king of the morning
 * will define the boundaries until you pay him with with nectar of the sun  yea   
 *
 *
 *@author Rolando<rolando@emptyart.xyz>
 */
public class boundaryAI : MonoBehaviour
{

    public float maxZpoint = 3000.0f;
    public GameObject AirPlane;
    public float returnPoint = -180.0f;
    public float maxYpoint = 3000.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(this.AirPlane.transform.position.z > this.maxZpoint){
           //this.AirPlane.transform.position.z = this.returnPoint;
           this.AirPlane.transform.position = new Vector3(this.AirPlane.transform.position.x , this.AirPlane.transform.position.y, this.returnPoint);
       }
    }
}
