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
 *  El Psicópata , gato felix , momia, mona, tarzan y arnoldillo eran agentes de la DIS expertos de Unix,Oracle y DB2 
 * entrenados en IBM de Guatemala y la Academia Militar de Toluca de Lerdo ,respaldados por un comando de carabineros expedicionarios.
 * en Tarbaca vendian carne de chancho que es cerdo ahumado en cbd , delicioso para playos maltratados de putas promiscuas.
 * cuando alguna puta asustaba un playo y se le moria , el psicopata se los recogia y le echaban una enfermera a ver si revivian
 * como eso se considera caridad catolica el oij nunca ha querido resolver esos casos ...
 *
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
