using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *   T
 * .-"-.
 * |  ___|
 * | (.\/.)
 * |  ,,,' 
 * | '###
 *  '----'
 * Displays and Manages Score int
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class scoreDisplay : MonoBehaviour
{
    public float windowX = 10;
    public float windowY = 65;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;
    public int Score =0;
    protected string theScore;
    public GUIStyle style;
    public string scorePrefix = " Points";
    
    // Start is called before the first frame update
    void Start()
    {
        this.UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void increaseScore(){

    }

    void OnGUI(){
		this.windowRect = new Rect(this.windowX,this.windowY,this.windowHeight,this.windowWidth);		
		GUI.Label(this.windowRect,this.theScore,this.style);
	}

	public void addScore(int scoreValue){
        //Debug.Log("increasing score .." + scoreValue);
		this.Score += scoreValue;
		this.UpdateScore ();
	}

	void UpdateScore(){
		this.theScore = Score  + this.scorePrefix;
	}
}
