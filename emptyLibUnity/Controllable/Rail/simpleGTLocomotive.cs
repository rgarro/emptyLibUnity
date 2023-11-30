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
 * Se cogieron a las del colegio de senoritas en un vagon del tren de orotina
 * sus novios goleaban en calleblancos , la pelicula esta en bar mazinger 5 esquinas
 * Venian borrachos de un partido de basketbal en rio frio , julia estaba en un motel en desampa, todos los que cantaban sabian
 * el liceo es una violacion .... 
 *
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
