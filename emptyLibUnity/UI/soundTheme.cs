using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *   _______________________________________
 * |  | | | |  |  | | | | | |  |  | | | |  |
 * |  | | | |  |  | | | | | |  |  | | | |  |
 * |  | | | |  |  | | | | | |  |  | | | |  |
 * |  |_| |_|  |  |_| |_| |_|  |  |_| |_|  |
 * |   |   |   |   |   |   |   |   |   |   |
 * |   |   |   |   |   |   |   |   |   |   |
 * |___|___|___|___|___|___|___|___|___|___|
 *
 * Plays music theme with ON/off Icon
 * 
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class soundTheme : MonoBehaviour
{
    protected bool sound_is_on = true;
    protected int buttons_x_corner = 150;
    public Texture2D SoundIcon;
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        this.audioData = GetComponent<AudioSource>();
        this.audioData.Play(0);
    }

    void OnGUI(){
        if(GUI.Button(new Rect(this.buttons_x_corner,20,40,40), this.SoundIcon)) 
        {
               //Debug.Log("sound click ...");
               if(this.sound_is_on){
                this.audioData.Pause();
                this.sound_is_on = false;
            } else {
                this.audioData.UnPause();
                this.sound_is_on = true;
            }
        }		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
