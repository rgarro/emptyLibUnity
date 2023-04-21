using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * ______
 *  L,.   ',
 *   \      ',_
 *    \   @   ',
 *     \ ^~^    ',
 *      \ ADOBE   ',
 *       \___Fireworks',_                        _..----.._
 *       [______       "'==.I\_____________..--"<__\\_n@___4\,_
 *     ,..-=T         __   ____________          \/  "'" O<==  ""-+.._
 *     I____|_____    }_>=========I>=**""''==-------------==-   " |   "'-.,___
 *     [_____,.--'"             _______         ""--=<""-----=====+==--''""
 *     ""'-=+..,,__,-----,_____|       |         -=* |
 *                 |__   /     |---,--'"---+------+-'"
 *                    """     d"b="        '-----+t
 *                            q_p                '@
 * Mi Coronel Kaddafi esta en Macondo ...
 *
 *@author Rolando<rolando@emptyart.xyz>
 */
public class f22FlightController : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    public GameObject AirPlane;
    private AudioSource soundPlayer;
    public AudioClip AirPlaneEngineSoundClip;
    public float minAltitude = 3.39f;
    public float maxAltitude = 14.35f;
    public float yardsPerSecond = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.moveForward();
    }

    void closeCockpit(){

    }

    void openCockpit(){

    }

     void moveForward(){
         //Debug.Log("moving forward ....");
        this.AirPlane.transform.Translate(Vector3.back * (Time.deltaTime * this.yardsPerSecond));
    }

    //must descend with arrow button
    void descend(){
        this.AirPlane.transform.Translate(Vector3.back * (Time.deltaTime * this.yardsPerSecond));
    }
}
