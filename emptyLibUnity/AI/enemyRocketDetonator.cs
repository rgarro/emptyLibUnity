//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *                                 o o
 *                                 o ooo
 *                                   o oo
 *                                      o o      |   #)
 *                                       oo     _|_|_#_    - el ara san juan recoge metano de las aguas negras de moin  -
 *                                         o   | 751   |
 *    __                    ___________________|       |_________________
 *   |   -_______-----------                                              \
 *  >|    _____                                 SS RECOPE         --->     )
 *   |__ -     ---------_________________________________________________ /
 *
 * on collide enemy rockets will subtract life points to collided and trigger explosion object
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class enemyRocketDetonator : MonoBehaviour
{

    public string enemyObjectTag = "perroNegro";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        //Debug.Log("colision BEGIN: ");
        Debug.Log("colision: "+ collision.gameObject.tag);
        if(collision.gameObject.tag == this.enemyObjectTag){
            Debug.Log("tome chichi : "+ collision.gameObject.tag);
        }
        //Debug.Log(collision.collider.name);
        //Debug.Log("colision END ");
    }
}
