using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *       ___------__
 * |\__-- /\       _-
 * |/    __      -
 * //\  /  \    /__
 * |  o|  0|__     --_
 * \\____-- __ \   ___-
 * (@@    __/  / /_
 *    -_____---   --_
 *     //  \ \\   ___-
 *   //|\__/  \\  \
 *   \_-\_____/  \-\
 *        // \\--\| 
 *   ____//  ||_
 *  /_____\ /___\
 *______________________
 * will prompt player name and save it game into restdb.io before game starts
 * saves scores and displays game history from restdb.io
 * Fuck firebase , heroku and its eternal postgres instances
 *
 *@athor Rolando<rgarro@gmail.com>
 */
public class restDBIOGameStarter : MonoBehaviour
{

    public string playerName = "Player Name";
    public int PlayerNameXPos = 25;
    public int PlayerNameYPos = 25;
    public int PlayerNameWidth = 100;
    public int PlayerNameHeight = 30;
    private string typedPlayerName = "";
    public string buttonLegend = "Start Game";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI () 
    {
        this.typedPlayerName = GUI.TextField (new Rect (this.PlayerNameXPos, this.PlayerNameYPos,this.PlayerNameWidth, this.PlayerNameHeight), this.playerName);
        if (GUI.Button(new Rect(this.PlayerNameXPos+100, this.PlayerNameYPos,this.PlayerNameWidth, this.PlayerNameHeight),this.buttonLegend)){
            Debug.Log("Clicked the button with text");
            Debug.Log(this.typedPlayerName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
