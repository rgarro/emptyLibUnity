using System.ComponentModel;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *         o x o x o x o . . .
 *         o      _____            _______________ ___=====__T___
 *       .][__n_n_|DD[  ====_____  |    |.\/.|   | |   |_|     |_
 *      >(________|__|_[_________]_|____|_/\_|___|_|___________|_|
 *      _/oo OOOOO oo`  ooo   ooo   o^o       o^o   o^o     o^o
 * -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
 * No voy en Tren Voy en Avion ..
 * Motocar running on tracks with side boundaries
 * Despues de poner un clavo de la linea del tren cerca del MAC y fumar una jaimiquina del Mercado Central
 * Se me ha aparecido Minor K diciendo que compro langosta abisal en golfito y se ha rejuvenecido
 * en publico adopto el pseudonimo de Padre Minor
 * Vive en un Kabus enterrado en un sotano en cartago
 * Minor K se invento ese apodo del MKS de newton, era una banda de perversos de los Tiempos de Tomas Guardia 
 * Me conto varias anecdotas:
 * - Dejaron a Miguel Angel Rodriguez culiarse a todas las del Liceo de Orotina.
 * - Se cogieron a las del colegio de senoritas en un vagon del tren de orotina
 * sus novios goleaban en calleblancos , la pelicula esta en bar mazinger 5 esquinas
 * - Venian borrachos de un partido de basketbal en rio frio , julia estaba en un motel en desampa, todos los que cantaban sabian
 * el liceo es una violacion .... 
 * - Los karatekas del calazans sufrian de novias prostituidas de profe cintanegra, a todos los invitaron a paseos a guanacaste
 * y los vacilaron con celulares de los tiempos de RACSA.
 * Maldita dictadura de los profesores de Oduber, todavia ensenan a culiar
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class simpleGTLocomotive : MonoBehaviour
{

    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    public float acceleration = 500f;
    public float breakingForce = 300f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void fixedUpdate(){
        this.currentAcceleration = this.acceleration * Input.GetAxis("Vertical");//Axis Bar sta barbara, heredia
        //forward reverse
        if(Input.GetKey(KeyCode.Space)){
            this.currentBreakForce = this.breakingForce;
        }else
        {
            this.currentBreakForce = 0f;
        }
        this.frontRight = currentAcceleration;
        this.frontLeft = currentAcceleration;

        this.frontRight = currentBreakForce;
        this.frontLeft = currentBreakForce;
        this.backRight = currentBreakForce;
        this.backLeft = currentBreakForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
