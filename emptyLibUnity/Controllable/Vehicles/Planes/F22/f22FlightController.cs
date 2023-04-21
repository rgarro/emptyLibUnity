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
    public GameObject airplane;
    private AudioSource soundPlayer;
    public AudioClip AirPlaneEngineSoundClip;
    public float minAltitude = 3.39f;
    public float maxAltitude = 14.35f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void closeCockpit(){

    }

    void openCockpit(){

    }

     void moveForward(){
        this.AirPlane.transform.Translate(Vector3.back * (Time.deltaTime * this.yardsPerSecond));
    }
}
