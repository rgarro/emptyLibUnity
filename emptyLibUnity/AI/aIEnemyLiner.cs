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
 *    === Will Spawn enemies traveling up to a rect ===
 *         Fast Strange Times Fast Strange Ways  
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
	//public Text scoreBox;
	public int Score;
	//public dashBoard theDashBoard;
	protected string theScore;
	public GUISkin btnSkin;

	//public Texture2D RestartIcon;
	//public Texture2D dashBoardPicIcon;
	//public float dbPicX = 600;
	//public float dbPicY = 10;
	public int count = 0;

	IEnumerator spawnWaves(){
		yield return new WaitForSeconds (startWait);
		while(true){
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (spawnValues.x - distanceFromSpanwnX, spawnValues.x + distanceFromSpanwnX), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				if(this.count%2 == 0){
					Instantiate (hazard, spawnPosition, spawnRotation);
				}else{
					Instantiate (hazardB, spawnPosition, spawnRotation);
				}
				this.count = this.count + 1;
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

	// Use this for initialization
	   

	void OnGUI(){
		GUI.Label(new Rect(410,10,150,20),this.theScore);

		/*if (GUI.Button (new Rect (10,10, 50, 50), this.RestartIcon))
        {
            //print ("you clicked the icon");
			this.doRestart();//Confirm Box Here
        }*/
		/*if (GUI.Button (new Rect (this.dbPicX,this.dbPicY, 40, 60), this.dashBoardPicIcon))
        {
            Debug.Log("jodido ...");
        }*/
	}

	public void addScore(int scoreValue){
		Score += scoreValue;
		UpdateScore ();
	}

	void UpdateScore(){
		this.theScore = Score  + " points";
	}

	/*public void doRestart(){
		//Debug.Log("will restart");
		Application.LoadLevel(Application.loadedLevel);
	}*/

}
