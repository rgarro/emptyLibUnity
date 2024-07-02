using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                        ___..............._
 *               __.. ' _'.""""""\\""""""""- .`-._
 *   ______.-'         (_) |      \\           ` \\`-. _
 *  /_       --------------'-------\\---....______\\__`.`  -..___
 *  | T      _.----._           Xxx|x...           |          _.._`--. _
 *  | |    .' ..--.. `.         XXX|XXXXXXXXXxx==  |       .'.---..`.     -._
 *  \_j   /  /  __  \  \        XXX|XXXXXXXXXXX==  |      / /  __  \ \        `-.
 *   _|  |  |  /  \  |  |       XXX|""'            |     / |  /  \  | |          |
 *  |__\_j  |  \__/  |  L__________|_______________|_____j |  \__/  | L__________J
 *      `'\ \      / ./__________________________________\ \      / /___________\
 *         `.`----'.'   dp                                `.`----'.'
 *           `""""'                                         `""""'
 * Coplanar aligment into the webgl canvas is an object shown in a STP video
 * What I read beteween the Lines, So game physics are lies 
 * interstate love song ... Σ 2sinΦ (d power 2 -v power bla bla bla ..
 * there were never a coplanar aligment just the computer pretends it can cheat us making us believe what you see
 * the 90s are gone, chris cornell died years ago,
 * Boyle P1V1 = P2V2 fucking friends on tv or cornell was the guy feeding the dogs
 * me da pereza hacer el SAT y me da la gana hablar mal ingles Jotos de la pinche verga ... 
 *
 *
 * 
 *@author Rolando<rgarro@gmail.com>
 */
public class copyRotationX : MonoBehaviour
{
    public GameObject fromObject;
    public GameObject toObject;

    private float fromDegrees;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void getFromRotation(){
        this.fromDegrees = this.fromObject.transform.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        this.getFromRotation();
        Vector3 newRotation = new Vector3(this.fromDegrees,this.toObject.transform.eulerAngles.y, this.toObject.transform.eulerAngles.z);
        this.toObject.transform.eulerAngles = newRotation; 
    }
}
