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
  public int doorSteps;
  public AudioClip closeDoorSound;
  private AudioSource audioPlayer;
  public bool startWithOpenDoors = true;

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

    }

    void closeRightDoor()
    {
      //neg y
    }

    void closeLeftDoor(){

    }

    void openBoth(){

    }

    void closeBoth(){

    }

    void setOpen(){

    }

    void setClose(){

    }

    void playOpenSound(){

    }

    void playCloseSound(){
      this.audioPlayer.clip = this.closeDoorSound;
      this.audioPlayer.Play();
    }
}
