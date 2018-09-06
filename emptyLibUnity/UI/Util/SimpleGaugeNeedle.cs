using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Tilts Gauge Needle from pivot adjusting tilter value from needle far side z rotations value
 *
 * @author Rolando <rgarro@gmail.com>
 */

namespace emptyLibUnity.UI.Util {
	public class SimpleGaugeNeedle : MonoBehaviour {

	public Image Needle;
	public float farLeft = 15.2F;
	public float farRight = -13.02F;

	protected double tilter;
	protected double rotation;
	private float rotationZ = 15.2F;
	private bool tilterIsSet = false; 

	void Start () {
		
	}
	
	public void getTilter(double tiltVal){
		this.tilter = tiltVal;
		Debug.Log("tilt ...");
		Debug.Log(this.tilter);
		this.setRotation()
	}

	protected void setRotation(){
		this.rotationZ = (this.tilter/this.farLeft)*this.farRight;
	}

	// Update is called once per frame
	void Update () {
		this.Needle.rectTransform.eulerAngles = new Vector3(0,0,rotationZ);
	}
}
}
