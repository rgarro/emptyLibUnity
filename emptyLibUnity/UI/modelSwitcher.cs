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
 * game object  two model switcher
 *
 *
 * @author Rolando <rgarro@gmail.com>
 */

public class modelSwitcher : MonoBehaviour
{
    protected int buttons_x_corner = 200;
    protected bool model_a_is_hidden =  false;
    protected bool model_b_is_hidden =  true;

    public Texture2D ModelAIcon;
    public Texture2D ModelBIcon;
    public GameObject ModelA;
    public GameObject ModelB;
    public string ButtonsLabel = "Models";
     //public GUISkin btnSkin;
    // Start is called before the first frame update
    void Start()
    {
        this.ModelB.SetActive(false);
    }

void OnGUI(){
      //GUI.skin = this.btnSkin;
      GUI.Box(new Rect(this.buttons_x_corner,10,108,73), this.ButtonsLabel);
      if(GUI.Button(new Rect(this.buttons_x_corner+10,40,40,40), this.ModelAIcon))
        {
            if(this.model_a_is_hidden){
                this.model_a_is_hidden = false;
                this.ModelA.SetActive(true);
                this.model_b_is_hidden = true;
                this.ModelB.SetActive(false);
            }
        }
    
        if(GUI.Button(new Rect(this.buttons_x_corner+55,40,40,40), this.ModelBIcon)) 
        {
            if(this.model_b_is_hidden){
                this.model_b_is_hidden = false;
                this.ModelB.SetActive(true);

                this.model_a_is_hidden = true;
                this.ModelA.SetActive(false);
            }
        }       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
