/**
 * la version trigonometrica es la que le corta la pinga al que mato al general ochoa.....
 *  
 *
 * @author Rolando <rgarro@gmail.com>
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunLoader : MonoBehaviour {


	public GameObject bullet;
	public GameObject turret;
	public float bulletSpeed;
	public float modelCorrectionAngle;
	private AudioSource gunSound;
	public AudioClip gunShot;
	private bool is_shooting = false;

	void Start () {
		this.gunSound = GetComponent<AudioSource> ();
		//this.gunSound.clip = gunShot;
		this.gunSound.volume = 0.2F;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			this.is_shooting = true;
			//this.gunSound.Play ();
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			this.is_shooting = false;
			//this.gunSound.Stop ();
		}
		if(this.is_shooting){
			this.gunSound.clip = gunShot;
			if (!this.gunSound.isPlaying) {
				this.gunSound.Play ();
			}
			float rotX = this.transform.localEulerAngles.x + modelCorrectionAngle;
			Quaternion rotation = Quaternion.Euler(rotX,turret.transform.eulerAngles.y,this.transform.localEulerAngles.z);
			Vector3 position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
			GameObject go = (GameObject)Instantiate (bullet,position,rotation);
			Rigidbody rb =  go.GetComponent<Rigidbody>();
			rb.velocity = transform.forward * bulletSpeed;
		}
	}
}
