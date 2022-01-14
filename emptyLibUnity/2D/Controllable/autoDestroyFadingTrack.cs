using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *       .-""""--.
 *      /         )
 *     /      --"`
 *    /       _`:---.
 *   |     .-'       `\
 *    \   /    .----'./
 *      \  : ,-' ~(.).)\
 *      \_| \      ._) |
 *       /   |  \.__, /
 *  _.--'    )`///-,-'
 * /        / _| (_\\
 *|        (____/____)
 * \     ___/       | _
 *  `---(            ` )
 *       `-,          .'
 *        (__.'._/'._/
 *             |`| |
 *          __/ / /
 *         //   | `--.
 *        ||    /_____)
 *  jgs   `=---`
 * Autodestroy Countdown with Fade on SpriteRenderer 2D
 * 
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class autoDestroyFadingTrack : MonoBehaviour
{

     public float secondsToLive = 3.0f;
     public float alphaLevel = 1.0f;
     public float transparencyRate = .011f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.countDown();
    }

     void countDown(){
        if(this.secondsToLive > 0){
            this.secondsToLive = this.secondsToLive - Time.deltaTime;
            this.alphaLevel -= this.transparencyRate;
            GetComponent<SpriteRenderer>().color = new Color(1,1,1,this.alphaLevel);
            //GetComponent<SpriteRenderer> ().color.a = ;
        }else{
            Destroy(this.gameObject);
        }
    }
}
