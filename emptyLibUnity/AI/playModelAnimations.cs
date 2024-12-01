using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *      0_
 *       \`.     ___
 *        \ \   / __>0
 *    /\  /  |/' / 
 *   /  \/   `  ,`'--.
 *  / /(___________)_ \
 *  |/ //.-.   .-.\\ \ \
 *  0 // :@ ___ @: \\ \/
 *    ( o ^(___)^ o ) 0
 *     \ \_______/ /
 * /\   '._______.'--.
 * \ /|  |<_____>    |
 *  \ \__|<_____>____/|__ 
 *   \____<_____>_______/
 *       |<_____>    |
 *       |<_____>    |
 *       :<_____>____:
 *      / <_____>   /|
 *     /  <_____>  / |
 *    /___________/  |
 *    |           | _|__
 *    |           | ---||_
 *    |   |L\/|/  |  | [__]
 *    |  \|||\|\  |  /
 *    |           | /
 *    |___________|/
 * State Machine that starts an animation from label
 *
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class playModelAnimations : MonoBehaviour
{

    public string animationLabel = "andabaila";
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        //this.anim = gameObject.GetComponent<Animation>();
        //this.anim[this.animationLabel].layer = 123;
        this.doThePlay();
    }
//the Bears next season gaining a huge number of yards
    void doThePlay(){
        this.anim.Play(this.animationLabel);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.anim.isPlaying)
        {
            return;
        }else{
            this.doThePlay();
        }

    }
}
