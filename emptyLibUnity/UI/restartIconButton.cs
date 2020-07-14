using System.Collections;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI(){
        if (GUI.Button (new Rect (this.IconX,this.IconY, 100, 50), this.RestartIcon)) 
        {
            //print ("you clicked the icon");
            this.doRestart();//Confirm Box Here
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
