using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *            _________________________
 *          ,'        _____            `.
 *        ,'       _.'_____`._           `.
 *       :       .'.-'  12 `-.`.           \
 *       |      /,' 11  .   1 `.\           :
 *       ;     // 10    |     2 \\          |
 *     ,'     ::        |        ::         |
 *   , '       || 9   ---O      3 ||         |
 *  /         ::                 ;;         |
 * :           \\ 8           4 //          |
 * |            \`. 7       5 ,'/           |
 * |             '.`-.__6__.-'.'            |
 * :              ((-._____.-))             ;
 *  \             _))       ((_            /
 *   `.          '--'       '--'         ,'
 *     `.______________________________,'
 *         ,-.
 *         `-'
 *            O
 *             o
 *              .     ____________
 *             ,('`)./____________`-.-,|
 *            |'-----\\--------------| |
 *            |_______^______________|,|
 *            |                      |   SSt
 * Displays cancellable TimeOut until restarts the entire game
 * supposed to be Relayed remotely by player action
 *
 * Un Delegado es un Relay Remoto Accesible publicamente, decia un perverso que compro un titulo en la U latina y se posaba de dueno ...
 *
 *
 *
 *@author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class restartTimerOut : MonoBehaviour
{
    public float windowX = 10;
    public float windowY = 65;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;
    
    public GUIStyle style;
    
    private string timeOutStr;
    private AudioSource soundPlayer;
    public AudioClip timerSoundClip;

    public bool playSoundOnTimerOn = true;
    public float soundVolume = 0.7F;
    public int SecondsFromTimeOut = 180;//small time shot away ...
    public string concatLegend = "seconds remaining";

    // Start is called before the first frame update
    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource>();
    }

    private void playSoundOn(){
        this.soundPlayer.PlayOneShot(this.timerSoundClip, this.soundVolume);
    }

     void OnGUI(){
		this.windowRect = new Rect(this.windowX,this.windowY,this.windowHeight,this.windowWidth);		
		GUI.Label(this.windowRect,this.timeOutStr,this.style);
	}

    public void startTimer(){
        StartCoroutine(updateTimerString());
    }

    public void stopTimer(){
        StopCoroutine(updateTimerString());
    }

    IEnumerator updateTimerString(){
        int seconds = this.SecondsFromTimeOut;
		while(true){
            seconds = seconds - 1;
            this.timeOutStr = seconds + " " + this.concatLegend;
			Debug.Log("timeStr: "+this.timeOutStr);
            if(seconds < 2){
                //restart game here
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
			yield return new WaitForSeconds (1);
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
