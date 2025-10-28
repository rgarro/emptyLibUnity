using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                       ---                                     
 *                    -        --                             
 *                --( /     \ )XXXXXXXXXXXXX                   
 *            --XXX(   O   O  )XXXXXXXXXXXXXXX-              
 *           /XXX(       U     )        XXXXXXX\               
 *         /XXXXX(              )--   XXXXXXXXXXX\             
 *        /XXXXX/ (      O     )   XXXXXX   \XXXXX\
 *        XXXXX/   /            XXXXXX   \   \XXXXX----        
 *        XXXXXX  /          XXXXXX         \  ----  -         
 * --     XXX  /          XXXXXX      \           ---        
 *  --  --  /      /\  XXXXXX            /     ---=         
 *    -        /    XXXXXX              '--- XXXXXX         
 *      --\/XXX\ XXXXXX                      /XXXXX         
 *        \XXXXXXXXX                        /XXXXX/
 *         \XXXXXX                         /XXXXX/         
 *           \XXXXX--  /                -- XXXX/       
 *            --XXXXXXX---------------  XXXXX--         
 *               \XXXXXXXXXXXXXXXXXXXXXXXX-            
 *                 --XXXXXXXXXXXXXXXXXX-                      
 * Will render flashMsg string displaying configured style at given rect position
 *
 *
 *
 *@author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class updatableText : MonoBehaviour
{
    public float windowX = 10;
    public float windowY = 65;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;
    
    public GUIStyle style;
    
    public string flashMsg = "I aint afraid of no ghost..";
    private AudioSource servoSoundPlayer;
	public AudioClip flashSoundClip;

    public bool playSoundOnUpdate = true;
    

    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
        /*private GameObject scoreUpdater;
        public string scoreManagerTag = "BatComputer";
        this.scoreUpdater = GameObject.FindWithTag(this.scoreManagerTag);
        scoreDisplay tmpObj = this.scoreUpdater.GetComponent(typeof(scoreDisplay)) as scoreDisplay;
            tmpObj.addScore(this.ptsToIncrease);*/
        
    }

    private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.flashSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

    void OnGUI(){
		this.windowRect = new Rect(this.windowX,this.windowY,this.windowHeight,this.windowWidth);		
		GUI.Label(this.windowRect,this.flashMsg,this.style);
	}

    public void setFlashMsg(string msg){
        Debug.Log("msg.." + msg);
        if(this.playSoundOnUpdate){
            this.playServoSoundOn();
        }
		this.flashMsg = msg;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
