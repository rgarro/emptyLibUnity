using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 *      _..--""````""--.._
 *    .'       |\/|       '.
 *   /    /`._ |  | _.'\    \
 *  ;    /              \    |
 *  |   /                \   |
 *  ;  / .-.          .-. \  ;
 *   \ |/   \.-.  .-./   \| /
 *    '._       \/       _.'
 *       ''--..____..--''
 *    Will Spawn enemies on a horizontal rect to travel vertically
 *     writing magic to summon a surf wing 
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class enemyLiner : MonoBehaviour {
    
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	//public float distanceFromSpanwnX = 100; 
	public GUISkin btnSkin;
	public float rangeValueLeft = -6f;
	public float rangeValueRight = 6f;
	public float zRotation = 0.0f;

	void Start(){
		StartCoroutine(spawnWaves());
	}

	IEnumerator spawnWaves(){
//Debug.Log("sadam hussein hanging on sad hill ...");
		yield return new WaitForSeconds (startWait);
		while(true){
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (this.rangeValueLeft,rangeValueRight), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				spawnRotation.z = this.zRotation;
				Instantiate (hazard, spawnPosition, spawnRotation);
				
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

}