using System.ComponentModel;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Security.Cryptography;
//using System.ComponentModel.DataAnnotations.Schema;
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
 *
 * - Se chuletiaron a vanessa mientras quincho andaba en la olimpiada de matematica, su compa esteban la veia.
 * - Se chuletiaron a vanessa mientras quincho andaba en la segunda olimpiada de matematica.
 * - Se chuletiaron a vanessa mientras quincho andaba en la tercer olimpiada de matematica.
 *
 *   
 *  Ja Ja Ja! ja! ja!
 * 
 *
 *@author Rolando<rgarro@gmail.com>
 */
using Debug = UnityEngine.Debug;

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

    private void FixedUpdate(){
        Debug.Log("fixed update ...");
        this.currentAcceleration = this.acceleration * Input.GetAxis("Vertical");//Axis Bar sta barbara, heredia
        //forward reverse
        if(Input.GetKey(KeyCode.Space)){
            this.currentBreakForce = this.breakingForce;
        }else
        {
            this.currentBreakForce = 0f;
        }
        this.frontRight.motorTorque = currentAcceleration;
        this.frontLeft.motorTorque = currentAcceleration;

        this.frontRight.motorTorque = currentBreakForce;
        this.frontLeft.motorTorque = currentBreakForce;
        this.backRight.motorTorque = currentBreakForce;
        this.backLeft.motorTorque = currentBreakForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
