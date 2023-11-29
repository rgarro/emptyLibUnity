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
        //forward reverse
        if(Input.GetKey(KeyCode.Space)){
            this.currentBreakForce = this.breakingForce;
        }else
        {
            this.currentBreakForce = 0f;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
