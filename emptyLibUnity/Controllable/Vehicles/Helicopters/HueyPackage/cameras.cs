using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *         .---.
 *         |[X]|
 *  _.==._.""""".___n__
 * d __ ___.-''-. _____b
 * |[__]  /."""".\ _   |
 * |     // /""\ \\_)  |
 * |     \\ \__/ //    |
 * |pentax\`.__.'/     |
 * \=======`-..-'======/
 *  `-----------------'  
 *  Switch 6 Cameras around the helicopter like an octtree 
 * 
 *@author Rolando<rgarro@gmail.com>
 */
public class cameras : MonoBehaviour
{

    public GameObject followingCamera;

    public GameObject frontCamera;

    public GameObject leftCamera;

    public GameObject rightCamera;
    protected bool follow_camera_is_hidden =  false;
    protected bool front_camera_is_hidden =  true;
    protected bool left_camera_is_hidden =  true;
    protected bool right_camera_is_hidden =  true;
   
     public int boxWidth = 265;
    public int boxHeight = 90;
    public int boxY = 10;
    public int buttonWidth = 40;
    public int buttonHeight = 40;
    public int buttonY = 40;
    public string boxLabel = "Cameras";

    public Texture2D FollowIcon;
    public Texture2D FrontIcon;
    public Texture2D LeftIcon;
    public Texture2D RightIcon;

    public GUISkin btnSkin;
    public int buttons_x_corner = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI(){
        GUI.skin = this.btnSkin;
        GUI.Box(new Rect(this.buttons_x_corner,this.boxY,this.boxWidth,this.boxHeight), this.boxLabel);
          if(GUI.Button(new Rect(this.buttons_x_corner+55,this.buttonY,this.buttonWidth,this.buttonHeight), FollowIcon)) 
        {
            if(this.follow_camera_is_hidden){
                this.follow_camera_is_hidden = false;
                this.followingCamera.SetActive(true);
                Debug.Log("Activating follow camera");
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
