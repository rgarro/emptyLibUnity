using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *         .---.
 *         |[X]|
 *  _.==._.""""".___n__
 * d __ ___.-''-. _____b
 * |[__]  /."""".\ _   |
 * |     // /""\ \\_)  |
 * |     \\ \__/ //    |
 * |pentax\`.__.'/     |
 * \=======`-..-'======/
 *  `-----------------'  
 *  Switch 6 Cameras around the helicopter like an octtree 
 * 
 *@author Rolando<rgarro@gmail.com>
 */
public class cameras : MonoBehaviour
{

    public GameObject followingCamera;

    public GameObject frontCamera;

    public GameObject leftCamera;

    public GameObject rightCamera;
    protected bool follow_camera_is_hidden =  false;
    protected bool front_camera_is_hidden =  false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
