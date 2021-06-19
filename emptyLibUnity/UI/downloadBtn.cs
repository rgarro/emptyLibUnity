using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *
 *                 _xAXAx_        /|  Ride Natty Ride !!                         ^^
 *              _xAXXXXXXX=x.    / |  /
 *          _xAXXXXXXXXV        /x |_o/    ^^                         ^^
 *      _xAXXXXXXXXXXXA        /---| :
 *sjo XXXXXXXXXXXXXXXXXAx      '---_/_\_
 *XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
 *
 * Jah say this. judgement it could never be with water
 * https://matterporttest-f4387.firebaseapp.com/TheGospelOfLuke.zip
 * Fire is burning may pull your own weight ...
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class downloadBtn : MonoBehaviour
{
    public Texture2D DownloadIcon;
    public float IconX = 10;
    public float IconY = 10;
    public float IconWidth = 128;
    public float IconHeight = 128;

    public string downloadUrl = "https://matterporttest-f4387.firebaseapp.com/TheGospelOfLuke.zip";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI(){
        if(GUI.Button(new Rect (this.IconX,this.IconY,this.IconWidth,this.IconHeight),this.DownloadIcon)) 
        {
            //print ("you clicked the icon");
            this.doDownload();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doDownload(){
        //Debug.Log("will download");
        Application.OpenURL(this.downloadUrl);
    }
}
