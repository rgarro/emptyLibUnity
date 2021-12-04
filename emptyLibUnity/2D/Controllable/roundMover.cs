using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * (                                 _
 * )                               /=>
 *  (  +____________________/\/\___ / /|
 *   .''._____________'._____      / /|/\
 *  : () :              :\ ----\|    \ )
 *   '..'______________.'0|----|      \
 *                    0_0/____/        \
 *                       |----    /----\
 *                      || -\\ --|      \
 *                      ||   || ||\      \
 *                       \\____// '|      \
 *                              .'/       |
 *                              .:/        |
 *                              :/_________|
 *
 *  El Psicópata , gato felix y arnoldillo eran agentes de la DIS expertos de unix
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class roundMover : MonoBehaviour
{
    public  float roundVelocity = 2.0f;
    public GameObject roundBody;
    public bool is_rocket = false;
    public bool is_round = false;

    void Start()
    {
        this.nextStep();
    }

    void nextStep(){
        transform.Translate(0,Time.deltaTime*this.roundVelocity,0);   
    }

    // Update is called once per frame
    void Update()
    {
        this.nextStep();
    }
}
