using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*
*        ______        _____
*        /|     |______|     |\
*       / |     |\____/|     | \
*    __|  |     |/ __ \|     |  |__
*   /  |  |     | /  \ |     |  |  \
*  / /| \ |     ||____||     | / |\ \
* / |_|  \|     |      |     |/  |_| |
* | |_|   |_____|______|_____|   |_| |
* | |_|  /  _____\____/_____  \  |_| |
* | |_| /__/_____\|  |/_____\__\ |_| |
* | |_||  | |     |  |     | |  ||_| |
* | |_||  | |     |  |     | |  ||_| |
* | |_||__| |     |__|     | |__||_| |
* | |_|\   \|     |__|     |/   /|_| |
* | |_| \___|    ______    |___/ |_| |
* | |_| |   |    \____/    |   | |_| |
* | |_| |   |      __      |   | |_| |
*  \ \| |   ||            ||   | |/ /
*   \_| |   | \          / |   | |_/
*      \|   |\ \________/ /|   |/
*       \___|-\|________|/-|___/
* Transformers are always shooting and pointing guns
* autobots are the disease ...
*
*@author Rolando<rgarro@gmail.com>
*/
public class turretRotator : MonoBehaviour
{

    public float rotationSteps = 3.014f;
    public GameObject TheTurret;
    private AudioSource servoSoundPlayer;
	public AudioClip servoSoundClip;
    private float tetha = 0.00f;//the angle

    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
        this.tetha = this.TheTurret.transform.rotation.z;
    }

     private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

     private void leftArrowAction(){
        //Debug.Log("left turret action ...");
        this.playServoSoundOn();
        this.tetha = this.TheTurret.transform.rotation.z + this.rotationSteps;
         this.TheTurret.transform.Rotate(0,0,this.tetha);
    }
    private void rightArrowAction(){
        //Debug.Log("right turret action ...");
        this.playServoSoundOn();
        this.tetha = this.TheTurret.transform.rotation.z - this.rotationSteps;
        this.TheTurret.transform.Rotate(0,0,this.tetha);
        
    }

    private void keyListeners(){
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.rightArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.leftArrowAction();
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.keyListeners();
    }
}
