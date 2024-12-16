using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                            ______
 *         |\_______________ (_____\\______________
 * HH======#H###############H#######################
 *         ' ~""""""""""""""`##(_))#H\"""""Y########
 *                           ))    \#H\       `"Y###
 *                           "      }#H)
 * state machine controlling self proppeled objects instantiation
 * 
 *
 *@author Rolando<rolando@emptyart.xyz>                       
 */
public class rocketShooter : MonoBehaviour
{

    public GameObject AirPlane;
    public GameObject roundObject;
    private AudioSource soundPlayer;
	public AudioClip gunShotClip;
    //public bool shootingOn = true;

    // Start is called before the first frame update
    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource> ();
		this.soundPlayer.volume = 0.2F;
        this.soundPlayer.clip = this.gunShotClip;
         this.soundPlayer.loop = true;
    }

    void shootRocket(){
		if (!this.soundPlayer.isPlaying) {
             Debug.Log("sound on ");
			this.soundPlayer.Play ();
		}
        Quaternion rotation = Quaternion.Euler(this.AirPlane.transform.localEulerAngles.x,this.AirPlane.transform.localEulerAngles.y,this.AirPlane.transform.localEulerAngles.z);
        //Quaternion rotation = this.AirPlane.transform.localEulerAngles;
        Debug.Log("shooting ..: "+this.AirPlane.transform.localEulerAngles.x);
		Vector3 position = new Vector3(this.AirPlane.transform.position.x,this.AirPlane.transform.position.y,this.AirPlane.transform.position.z);
        GameObject rocket = (GameObject)Instantiate (this.roundObject,position,rotation);
    }

    // Update is called once per frame
    void Update()
    {
        this.joystickControls();
    }

    void joystickControls(){
        if(Input.GetKey("space"))
        {
            this.shootRocket();
        }
    }
}
