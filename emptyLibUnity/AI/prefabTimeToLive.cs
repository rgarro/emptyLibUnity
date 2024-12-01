using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *  |\/\/\/|  
 *  |      |  
 *  |      |  
 *  | (o)(o)  
 *  C      _) 
 *   | ,___|  
 *   |   /    
 *  /____\    
 * /      \
 * State Machine removing prefab after after integer seconds to live
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class prefabTimeToLive : MonoBehaviour
{
    public int seconds_to_live;
	private float timer;

	// Use this for initialization
	void Start () {
		//Debug.Log (" ...");
	}
	
	// Update is called once per frame
	void Update () {
		this.timer += 1.0F * Time.deltaTime;
		//Debug.Log ("tiramos ..." + timer);
		if (this.timer >= this.seconds_to_live)
		{
			GameObject.Destroy(this.gameObject);
		}
	}
}
