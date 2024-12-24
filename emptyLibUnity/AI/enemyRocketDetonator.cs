using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *                                 o o
 *                                 o ooo
 *                                   o oo
 *                                      o o      |   #)
 *                                       oo     _|_|_#_    -la mota colombiana la venden 200 al sur de la clinica biblica-
 *                                         o   | 751   |
 *    __                    ___________________|       |_________________
 *   |   -_______-----------                                              \
 *  >|    _____                                                   --->     )
 *   |__ -     ---------_________________________________________________ /
 *
 * on collide enemy rockets will subtract life points to collided 
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class enemyRocketDetonator : MonoBehaviour
{
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
        Debug.Log("colision here: ");
        Debug.Log(collision.collider.name);
    }
}
