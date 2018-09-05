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

	protected float tilter;
	private bool tilterIsSet = false; 

	void Start () {
		
	}
	
	public void getTilter(float tiltVal){
		this.tilter = tiltVal;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
}
