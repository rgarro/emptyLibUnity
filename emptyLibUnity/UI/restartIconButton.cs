﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public Rect windowRect = new Rect(20, 20, 120, 50);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI(){
        if(GUI.Button(new Rect (this.IconX,this.IconY,this.IconWidth,this.IconHeight),this.RestartIcon)) 
        {
            //print ("you clicked the icon");
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
