using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *      ,*-~"`^"*u_                                _u*"^`"~-*,
 *  p!^       /  jPw                            w9j \        ^!p
 *w^.._      /      "\_                      _/"     \        _.^w
 *     *_   /          \_      _    _      _/         \     _*
 *       q /           / \q   ( `--` )   p/ \          \   p
 *       jj5****._    /    ^\_) o  o (_/^    \    _.****6jj
 *                *_ /      "==) ;; (=="      \ _*
 *                 `/.w***,   /(    )\   ,***w.\"
 *                  ^ ilmk ^c/ )    ( \c^      ^
 *                          'V')_)(_('V'
 *  Places a SoundCloud button that play/pause audioData
 *
 * @author Rolando <rgarro@gmail.com>
 */

public class soundCloudLoopButton : MonoBehaviour
{
     public Texture2D soundCloudIcon;
    protected bool audio_is_on = true;
    public AudioSource audioData;
    public float IconX = 10;
    public float IconY = 10;
    void Start()
    {
        this.audioData = GetComponent<AudioSource>();
        this.audioData.Play(0);
    }

    void OnGUI(){
        if (GUI.Button (new Rect (this.IconX,this.IconY, 100, 50), soundCloudIcon)) 
        {
            if(this.audio_is_on){
                this.audioData.Pause();
                this.audio_is_on = false;
            }else{
                this.audioData.Play(0);
                this.audio_is_on = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
