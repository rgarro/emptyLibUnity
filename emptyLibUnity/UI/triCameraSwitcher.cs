using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *         .-------------------.
 *        /--"--.------.------/|
 *        |Kodak|__Ll__| [==] ||
 *        |     | .--. | """" ||
 *        |     |( () )|      ||
 *   jgs  |     | `--' |      |/
 *        `-----'------'------'
 *
 *------------------------------------------------
 * Allows to switch from 3 available cameras
 * Main camera should be active, buttons horizontal line
 *
 *
 *
 * @author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class triCameraSwitcher : MonoBehaviour
{
     protected bool follow_camera_is_hidden =  true;
     protected bool front_camera_is_hidden =  true;
    protected bool main_camera_is_hidden =  false;
    public int buttons_x_corner = 200;

    public GUISkin btnSkin;
    public Texture2D FrontCameraIcon;
    public Texture2D FollowCameraIcon;
    public Texture2D MainCameraIcon;
    
    public GameObject follow_camera;
    public GameObject front_camera;
    public GameObject main_camera;
    public int boxWidth = 265;
    public int boxHeight = 90;
    public int boxY = 10;
    public int buttonWidth = 40;
    public int buttonHeight = 40;
    public int buttonY = 40;
    public string boxLabel = "Cameras";

    public bool displayButtons = true;

    public int spaceXCornerFromFirst = 55;
    
    // Start is called before the first frame update
    void Start()
    {
        this.follow_camera.SetActive(false);
        this.front_camera.SetActive(false);
        this.main_camera.SetActive(true);
    }

     void OnGUI(){
        if(this.displayButtons){
            GUI.skin = this.btnSkin;
            GUI.Box(new Rect(this.buttons_x_corner,this.boxY,this.boxWidth,this.boxHeight), this.boxLabel);
            if(GUI.Button(new Rect(this.buttons_x_corner+this.spaceXCornerFromFirst,this.buttonY,this.buttonWidth,this.buttonHeight), FollowCameraIcon))
            {
                if(this.follow_camera_is_hidden){
                    this.main_camera_is_hidden = true;
                    this.main_camera.SetActive(false);
                    this.front_camera_is_hidden = true;
                    this.front_camera.SetActive(false);
                    this.follow_camera_is_hidden = false;
                    this.follow_camera.SetActive(true);                
                } 
            }
    
            if(GUI.Button(new Rect(this.buttons_x_corner+55,this.buttonY,this.buttonWidth,this.buttonHeight), MainCameraIcon)) 
            {
                if(this.main_camera_is_hidden){
                    this.follow_camera_is_hidden = true;
                    this.follow_camera.SetActive(false);
                    this.front_camera_is_hidden = true;
                    this.front_camera.SetActive(false);
                    this.main_camera_is_hidden = false;
                    this.main_camera.SetActive(true);
                } 
            }
            if(GUI.Button(new Rect(this.buttons_x_corner+55,this.buttonY,this.buttonWidth,this.buttonHeight), FrontCameraIcon)) 
            {
                if(this.main_camera_is_hidden){
                    this.follow_camera_is_hidden = true;
                    this.follow_camera.SetActive(false);
                    this.main_camera_is_hidden = true;
                    this.main_camera.SetActive(false);
                    this.front_camera_is_hidden = false;
                    this.front_camera.SetActive(true);
                } 
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
