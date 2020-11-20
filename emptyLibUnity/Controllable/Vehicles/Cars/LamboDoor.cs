using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                       ___..............._
 *              __.. ' _'.""""""\\""""""""- .`-._
 *  ______.-'         (_) |      \\           ` \\`-. _
 * /_       --------------'-------\\---....______\\__`.`  -..___
 * | T      _.----._           Xxx|x...           |          _.._`--. _
 * | |    .' ..--.. `.         XXX|XXXXXXXXXxx==  |       .'.---..`.     -._
 * \_j   /  /  __  \  \        XXX|XXXXXXXXXXX==  |      / /  __  \ \        `-.
 * _|  |  |  /  \  |  |       XXX|""'            |     / |  /  \  | |          |
 * |__\_j  |  \__/  |  L__________|_______________|_____j |  \__/  | L__________J
 *     `'\ \      / ./__________________________________\ \      / /___________\
 *        `.`----'.'   dp                                `.`----'.'
 *          `""""'                                         `""""'
 *
 */
public class LamboDoor : MonoBehaviour
{
  public GameObject LeftDoor;
  public GameObject RightDoor;
  public float openedDoorAngle;
  public float closedDoorAngle;
  public float doorSteps;
  public AudioClip closeDoorSound;
  public AudioClip openDoorSound;
  private AudioSource audioPlayer;
  public bool startWithOpenDoors = true;
  public bool closeDoors = true;

    // Start is called before the first frame update
    void Start()
    {
        this.audioPlayer = GetComponent<AudioSource>();
        if(this.startWithOpenDoors){
          this.setOpen();
        }
        if(!this.startWithOpenDoors){
          this.setClose();
        }
    }

    // Update is called once per frame
    void Update()
    {
      if(this.closeDoors){
        this.closingLeftDoor();
        this.closingRightDoor();
      }

    }

    void closingRightDoor()
    {
 Debug.Log("closing left");     
      if(this.RightDoor.transform.rotation.y > (this.closedDoorAngle * -1)){
        this.RightDoor.transform.Rotate(this.RightDoor.transform.rotation.x,(this.RightDoor.transform.rotation.y - this.doorSteps),this.RightDoor.transform.rotation.z);
      }else{
        this.closeDoors = false;
        this.playCloseSound();
      }
    }

    void closingLeftDoor(){
      if(this.LeftDoor.transform.rotation.y >this.closedDoorAngle){
        this.LeftDoor.transform.Rotate(this.LeftDoor.transform.rotation.x,(this.LeftDoor.transform.rotation.y - this.doorSteps),this.LeftDoor.transform.rotation.z);
      }else{
        this.closeDoors = false;
        this.playCloseSound();
      }
    }

    void openBoth(){

    }

    void closeBoth(){

    }

    void setOpen(){
      this.RightDoor.transform.Rotate(this.RightDoor.transform.rotation.x,(this.openedDoorAngle *-1),this.RightDoor.transform.rotation.z);
      this.LeftDoor.transform.Rotate(this.LeftDoor.transform.rotation.x,this.openedDoorAngle,this.LeftDoor.transform.rotation.z);
      this.startWithOpenDoors = false;
      this.playOpenSound();
    }

    void setClose(){
      this.RightDoor.transform.Rotate(this.RightDoor.transform.rotation.x,(this.closedDoorAngle *-1),this.RightDoor.transform.rotation.z);
      this.LeftDoor.transform.Rotate(this.LeftDoor.transform.rotation.x,this.closedDoorAngle,this.LeftDoor.transform.rotation.z);
      this.playCloseSound();
    }

    void playOpenSound(){
      this.audioPlayer.clip = this.openDoorSound;
      this.audioPlayer.Play();
    }

    void playCloseSound(){
      this.audioPlayer.clip = this.closeDoorSound;
      this.audioPlayer.Play();
    }
}
