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
* will promp player name and save it game into restdb.io before game starts
* saves scores and displays game history from restdb.io
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI () 
    {
        this.typedPlayerName = GUI.TextField (new Rect (this.PlayerNameXPos, this.PlayerNameYPos,this.PlayerNameWidth, this.PlayerNameHeight), this.playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
