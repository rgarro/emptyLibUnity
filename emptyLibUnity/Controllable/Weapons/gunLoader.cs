﻿/**
 *                    /-----^\
 *                   /==     |
 *               +-o/   ==B) |            
 *                  /__/-----|        
 *                     =====                        
 *                     ( \ \ \        
 *                      \ \ \ \  
 *                       ( ) ( )      
 *                       / /  \ \        
 *                     / /     | |        
 *                     /        |  
 *                   _^^oo    _^^oo  
 * on key pushes bullet from given position and  rotation at given speed
 *
 * @author Rolando <rgarro@gmail.com>
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunLoader : MonoBehaviour {


	public GameObject bulletObj;
	public GameObject turretObj;
	public float bulletSpeed = 75;
	public float correctionAngle = 90;
	private AudioSource soundPlayer;
	public AudioClip gunShotClip;
	private bool shootingOn = false;

	void Start () {
		this.soundPlayer = GetComponent<AudioSource> ();
		this.soundPlayer.volume = 0.2F;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			this.shootingOn = true;
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			this.shootingOn = false;
		}
		if(this.shootingOn){
			this.soundPlayer.clip = this.gunShotClip;
			if (!this.soundPlayer.isPlaying) {
				this.soundPlayer.Play ();
			}
			//float rotX = this.transform.localEulerAngles.x + this.correctionAngle;
			//Quaternion rotation = Quaternion.Euler(rotX,this.turretObj.transform.eulerAngles.y,this.transform.localEulerAngles.z);
			float rotationX = this.transform.localEulerAngles.x;// + this.correctionAngle;
			float elevationY = this.transform.localEulerAngles.y;
			float horizontalRotationZ = this.turretObj.transform.localEulerAngles.z; 
			Quaternion rotation = Quaternion.Euler(rotationX,elevationY,horizontalRotationZ);
			Vector3 position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
			GameObject go = (GameObject)Instantiate (this.bulletObj,position,rotation);
			Rigidbody rb =  go.GetComponent<Rigidbody>();
			rb.velocity = transform.forward * this.bulletSpeed;
		}
	}
}
