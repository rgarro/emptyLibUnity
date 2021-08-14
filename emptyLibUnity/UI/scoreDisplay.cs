using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDisplay : MonoBehaviour
{
    public float windowX = 10;
    public float windowY = 65;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;
    public int Score =0;
    protected string theScore;
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
		GUI.Label(this.windowRect,this.theScore);
	}

	public void addScore(int scoreValue){
		Score += scoreValue;
		UpdateScore ();
	}

	void UpdateScore(){
		this.theScore = Score  + " Points";
	}
}
