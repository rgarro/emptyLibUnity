using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*  ░░░░░░███████ ]▄▄▄▄▄▄▄▄▃
*  ▂▄▅█████████▅▄▃▂
* I███████████████████].
* ◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤...
*
* c mayor scale controlling a sprite with triangulated forward from a qwerty input  
*
*@author Rolando <rgarro@gmail.com>
*/
public class arrowKeyControlledRotableBase : MonoBehaviour
{

    public float rotationSteps = 3.014f;
    private GameObject TheBase;
    private AudioSource servoSoundPlayer;
	public AudioClip servoSoundClip;

    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
        this.TheBase = GetComponent<GameObject>();
    }

    private void keyListeners(){
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.upArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.downArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rightArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.leftArrowAction();
        }
    }


     private void leftArrowAction(){
        Debug.Log("left arrow action ...");
        float rotate = this.TheBase.transform.rotation.z + this.rotationSteps;
         this.TheBase.transform.Rotate(0,0,rotate);
    }
    private void rightArrowAction(){
        Debug.Log("right arrow action ...");
        float rotate = this.TheBase.transform.rotation.z + this.rotationSteps;
        this.TheBase.transform.Rotate(0,0,rotate);
        /*
        If you have the hypotenuse, multiply it by sin(θ) to get the length of the side opposite to the angle.
         Alternatively, multiply the hypotenuse by cos(θ) to get the side adjacent to the angle.
          If you have the non-hypotenuse side adjacent to the angle, divide it by cos(θ) to get the length of the hypotenuse.
        */
    }

    private void upArrowAction(){
        Debug.Log("upArrowAction here...");
        this.playServoSoundOn();
    }

    private void downArrowAction(){
        Debug.Log("downArrowAction here...");
    }

    private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.keyListeners();
    }

}
