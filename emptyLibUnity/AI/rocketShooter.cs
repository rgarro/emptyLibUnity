using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketShooter : MonoBehaviour
{

    public GameObject AirPlane;
    public GameObject roundObject;
    private AudioSource soundPlayer;
	public AudioClip gunShotClip;
    public bool shootingOn = true;

    // Start is called before the first frame update
    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource> ();
		this.soundPlayer.volume = 0.2F;
    }

    void shootRocket(){
        this.soundPlayer.clip = this.gunShotClip;
		if (!this.soundPlayer.isPlaying) {
			this.soundPlayer.Play ();
		}
        Debug.Log("shooting ..");
        //Quaternion rotation = Quaternion.Euler(rotationX,elevationY,horizontalRotationZ);
        //Quaternion rotation = this.AirPlane.transform.localEulerAngles;
		//Vector3 position = new Vector3(this.AirPlane.transform.position.x,this.AirPlane.transform.position.y,this.AirPlane.transform.position.z);
        //GameObject rocket = (GameObject)Instantiate (this.roundObject,position,rotation);
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
