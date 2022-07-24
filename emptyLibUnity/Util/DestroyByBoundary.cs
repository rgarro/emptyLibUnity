using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using emptyLibUnity.UI.Util;
using System;
using emptyLibUnity.UI.Util;
using UnityEngine.UI;
/**
* Destroy or restart game by colliding
*
*@author Rolando<rgarro@gmail.com>
*/
public class DestroyByBoundary : MonoBehaviour {

	void OnTriggerExit(Collider other)
	{
		// Destroy everything that leaves the trigger
		//Destroy(other.gameObject);
		Debug.Log("will restart");
        //find confirm UI
        //Application.LoadLevel(Application.loadedLevel);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
	}

	 private void OnTriggerEnter(Collider other)
    {
		Debug.Log("will restart ..");
    }
}
