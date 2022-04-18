using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *
 *                ,,,,,,,,,,---''''---,,,,,,,,,,
 *      --''''''''          ````][''''          ''''''''--
 *                           _3'''':.
 * _                  .,---------------.
 * \\    / _________./  |[__]| o   |J@"\\__
 *  \\==o=========:;    |____|[IL__|''''/_/')
 *     /            `'-,._____===\=_____.,-'
 *                          \         \     ,
 *                    """"""""""""""""""""""
 * Increases engine power rotation speed and helicopter elevation
 * We are going to change the name of this radio station to Kowalsky
 * to whom speed meant freedom of soul ...
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class enginePowerElevator : MonoBehaviour
{
    public float initialAltitude = 0.0f;
    public float maxAltitude = 300.0f;
    public GameObject blades;

    public GameObject helicopter;

    private float pitch;

    private float yaw; 

    private float rudderAngle;

    private AudioSource soundPlayer;
    public AudioClip helicopterThrottleSoundClip;
    

    private int rotationSteps = 5;
    // Start is called before the first frame update
    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource> ();
        this.soundPlayer.volume = 0.2F;
        this.playEngineSound();
    }

    private void playEngineSound(){
        this.soundPlayer.clip = this.helicopterThrottleSoundClip;
        if (!this.soundPlayer.isPlaying) {
            this.soundPlayer.Play ();
        }
    }

    void rotateBlades(){

    }

    void increseRotationSpeed(){

    }

    void increaseHelicopterAltitude(){

    }

    void yawLeft(){

    }

    void yawRight(){

    }

    void pitchFront(){

    }

    void pitchBack(){

    }

    void moveForward(){

    }

    void moveBackward(){

    }

    void rudderLeft(){

    }

    void rudderRight(){

    }

    void joystickControls(){
        //find a cheap joystick ina walmart next to an airbase where real pilots have stepped
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
