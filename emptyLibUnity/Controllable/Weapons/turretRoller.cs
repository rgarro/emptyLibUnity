/**
 *                   ____                  
 *                _.' :  `._               
 *            .-.'`.  ;   .'`.-.           
 *   __      / : ___\ ;  /___ ; \      __  
 * ,'_ ""--.:__;".-.";: :".-.":__;.--"" _`,
 * :' `.t""--.. '<@.`;_  ',@>` ..--""j.' `;
 *      `:-.._J '-.-'L__ `-- ' L_..-;'     
 *        "-.__ ;  .-"  "-.  : __.-"       
 *            L ' /.------.\ ' J           
 *             "-.   "--"   .-"            
 *            __.l"-:_JL_;-";.__           
 *   -- Frankling Marshall es un Violador --
 *
 * turns horizontally rotationSteps current transform
 * clockwise or counterclockwise from input turn key
 * 
 * @author Rolando<rgarro@gmail.com>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretRoller : MonoBehaviour
{
 public string leftTurnKey = "f";
    public string rightTurnKey = "g";
    public float rotationSteps;
    private float turretRotationZ;
    private AudioSource servoSoundPlayer;
    public AudioClip servoSoundClip;
    private bool gRight;
    private bool gLeft;

    void Start () {
        this.turretRotationZ = this.transform.rotation.z;
        this.servoSoundPlayer = GetComponent<AudioSource> ();
        gRight = false;
        gLeft = false;
    }
    void Update () {
        if(Input.GetKeyDown(this.leftTurnKey)){
            gLeft = true;
            gRight = false;
        }
        if(gLeft){
            this.turretRotationZ = (Mathf.Abs(this.turretRotationZ) + rotationSteps)*-1;
            this.rotateTurret();
        }
        if(Input.GetKeyDown(this.rightTurnKey)){
            gRight = true;
            gLeft = false;
        }
        if(gRight){
            this.turretRotationZ = Mathf.Abs(this.turretRotationZ) + rotationSteps;
            this.rotateTurret();
        }
        if (Input.GetKeyUp (this.rightTurnKey) || Input.GetKeyUp(this.leftTurnKey)) {
            gRight = false;
            gLeft = false;
            this.servoSoundPlayer.Stop ();
        }
    }

    private void rotateTurret(){
		this.playServoSoundOn();
		this.transform.Rotate(0,0,this.turretRotationZ);
	}
    private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }
}