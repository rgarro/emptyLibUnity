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
public class enemyLiner : MonoBehaviour {
    
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public float distanceFromSpanwnX = 100; 
	public int Score;
	//public dashBoard theDashBoard;
	protected string theScore;
	public GUISkin btnSkin;

	//public Texture2D RestartIcon;
	//public Texture2D dashBoardPicIcon;
	//public float dbPicX = 600;
	//public float dbPicY = 10;
	//public int count = 0;
	public float windowX = 10;
    public float windowY = 65;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;

	void Start(){
		this.UpdateScore();
		StartCoroutine(spawnWaves());
	}

	IEnumerator spawnWaves(){
Debug.Log("spawning waves ...");
		yield return new WaitForSeconds (startWait);
		while(true){
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (spawnValues.x - distanceFromSpanwnX, spawnValues.x + distanceFromSpanwnX), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

	void OnGUI(){
Debug.Log("starting on gui ..."+this.theScore);		
Debug.Log("starting on gui ..."+this.theScore);
		this.windowRect = new Rect(this.windowX,this.windowY,this.windowHeight,this.windowWidth);
        //this.windowRect = GUI.Window(0,windowRect,WindowFunction,this.labelString);		
		GUI.Label(this.windowRect,this.theScore);
	}

	public void addScore(int scoreValue){
		Score += scoreValue;
		UpdateScore ();
	}

	void UpdateScore(){
		this.theScore = Score  + " points";
	}

}