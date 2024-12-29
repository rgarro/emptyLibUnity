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
 *    === Will Spawn Game Objects Along a Bottom Spawn Vector 
 *        Screening the Instances randomly  ===
 *         Fast Strange Times Fast Strange Ways  
 *
 *
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class aIEnemyLiner : MonoBehaviour {

	public GameObject hazard;
	public GameObject hazardB;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public float distanceFromSpanwnX = 100;
	public int Score;
	protected string theScore;
	public GUISkin btnSkin;
	public int count = 0;
	private IEnumerator coroutine;

	void Start(){
		coroutine = spawnWaves();
        StartCoroutine(coroutine);
	}

	IEnumerator spawnWaves(){
		yield return new WaitForSeconds (startWait);
		while(true){
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (spawnValues.x - distanceFromSpanwnX, spawnValues.x + distanceFromSpanwnX), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				if(this.count%2 == 0){
					//print("instanciando A");
					Instantiate (hazard, spawnPosition, spawnRotation);
				}else{
					//print("instanciando B");
					Instantiate (hazardB, spawnPosition, spawnRotation);
				}
				this.count = this.count + 1;
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}  

	void OnGUI(){
		GUI.Label(new Rect(410,10,150,20),this.theScore);

	}

	public void addScore(int scoreValue){
		Score += scoreValue;
		UpdateScore ();
	}

	void UpdateScore(){
		this.theScore = Score  + " points";
	}

}
