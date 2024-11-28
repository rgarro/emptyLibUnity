using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabTimeToLive : MonoBehaviour
{
    public int seconds_to_live;
	public float timer;

	// Use this for initialization
	void Start () {
		//Debug.Log ("tiramos ...");
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1.0F * Time.deltaTime;
		//Debug.Log ("tiramos ..." + timer);
		if (timer >= seconds_to_live)
		{
			GameObject.Destroy(this.gameObject);
		}
	}
}
