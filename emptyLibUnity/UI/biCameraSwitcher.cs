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
 * Allows to switch from two available cameras
 * follow camera showld be active, buttons horizontal line
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class biCameraSwitcher : MonoBehaviour
{
    protected bool gun_camera_is_hidden =  true;//forklift carriage camera
    protected bool follow_camera_is_hidden =  false;
    protected int buttons_x_corner = 200;

    public GUISkin btnSkin;
    public Texture2D GunCamera2d;
    public Texture2D FollowIcon;
    
    public GameObject gun_camera;
    public GameObject follow_camera;
    public int boxWidth = 265;
    public int boxHeight = 90;
    public int boxY = 10;
    public int buttonWidth = 40;
    public int buttonHeight = 40;
    public int buttonY = 40;
    public string boxLabel = "Cameras";
   

    void Start()
    {
        
        this.gun_camera.SetActive(false);
        this.follow_camera.SetActive(true);
       
    }

    void OnGUI(){
      GUI.skin = this.btnSkin;
      GUI.Box(new Rect(this.buttons_x_corner,this.boxY,this.boxWidth,this.boxHeight), this.boxLabel);
      if(GUI.Button(new Rect(this.buttons_x_corner+10,this.buttonY,this.buttonWidth,this.buttonHeight), GunCamera2d))
        {
            if(this.gun_camera_is_hidden){
                this.gun_camera_is_hidden = false;
                this.gun_camera.SetActive(true);

                
                this.follow_camera_is_hidden = true;
                this.follow_camera.SetActive(false);
                
            } 
        }
    
        if(GUI.Button(new Rect(this.buttons_x_corner+55,this.buttonY,this.buttonWidth,this.buttonHeight), FollowIcon)) 
        {
            if(this.follow_camera_is_hidden){
                this.follow_camera_is_hidden = false;
                this.follow_camera.SetActive(true);

                this.gun_camera_is_hidden = true;
                this.gun_camera.SetActive(false);

                
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}

