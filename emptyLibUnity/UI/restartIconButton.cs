using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
/**
 *      _..--""````""--.._
 *    .'       |\/|       '.
 *   /    /`._ |  | _.'\    \
 *  ;    /              \    |
 *  |   /                \   |
 *  ;  / .-.          .-. \  ;
 *   \ |/   \.-.  .-./   \| /
 *    '._       \/       _.'
 *       ''--..____..--''
 * Places a Restart Icon Button 
 * restart current scene on click
 * 
 * @author Rolando <rgarro@gmail.com>
 */

public class restartIconButton : MonoBehaviour
{
    public Texture2D RestartIcon;
    public float IconX = 10;
    public float IconY = 10;
    public float IconWidth = 128;
    public float IconHeight = 128;
    public float windowX = 20;
    public float windowY = 20;
    public float windowWidth = 300;
    public float windowHeight = 300;
    private Rect windowRect; 

    // Start is called before the first frame update
    void Start()
    {
        this.windowRect = new Rect(this.windowX, this.windowY, this.windowWidth,this.windowHeight);
    }

    void OnGUI(){
        if(GUI.Button(new Rect (this.IconX,this.IconY,this.IconWidth,this.IconHeight),this.RestartIcon)) 
        {
            Debug.Log("you clicked the icon");
            windowRect = GUI.Window(0, this.windowRect, this.DoMyWindow, "My Window");
            //this.doRestart();//Confirm Box Here
        }
    }

    void DoMyWindow(int windowID){
        if (GUI.Button(new Rect(10, 20, 100, 20), "Hello World"))
        {
            print("Got a click");
            Debug.Log("here in the window");
        }
        // Make the windows be draggable.
        GUI.DragWindow(new Rect(0, 0, 10000, 10000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doRestart(){
        //Debug.Log("will restart");
        //Application.LoadLevel(Application.loadedLevel);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

}
