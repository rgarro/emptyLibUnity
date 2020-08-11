/**
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
 public string leftTurnKey;
    public string rightTurnKey;
    public float rotationSteps;
    public float xPivot;
    public float zPivot;
    private float yRot;
    private Vector3 tPos;
    private AudioSource servoSoundPlayer;
    public AudioClip servoSoundClip;
    private bool gRight;
    private bool gLeft;

    void Start () {
        this.yRot = this.transform.rotation.y;
        this.servoSoundPlayer = GetComponent<AudioSource> ();
        gRight = false;
        gLeft = false;
    }

    void Update () {
        //Debug.Log ("here IM is only rocknroll ....");
        if(Input.GetKeyDown(this.leftTurnKey)){
            gLeft = true;
        }
        if(gLeft){
            this.playServoSoundOn();
            this.yRot = this.yRot - rotationSteps;
            Quaternion target = Quaternion.Euler(this.xPivot,this.yRot,this.zPivot);
            this.transform.SetPositionAndRotation(this.transform.position,target);
            //transform.Rotate(Vector3.left * Time.deltaTime * rotationSteps);///la 
        }
        if(Input.GetKeyDown(this.rightTurnKey)){
            gRight = true;
        }
        if(gRight){
            this.playServoSoundOn();
            //transform.Rotate(Vector3.right * Time.deltaTime * rotationSteps);
            this.yRot = this.yRot + rotationSteps;
            Quaternion target = Quaternion.Euler(this.xPivot,this.yRot,this.zPivot);
            this.transform.SetPositionAndRotation(this.transform.position,target);
        }
        if (Input.GetKeyUp (this.rightTurnKey) || Input.GetKeyUp(this.leftTurnKey)) {
            gRight = false;
            gLeft = false;
            this.servoSoundPlayer.Stop ();
        }
    }

    private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

}
