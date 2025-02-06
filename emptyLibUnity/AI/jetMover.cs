using System;
/**
 *              _.-'| ------- \,._
 *           .-'    |         |   ~'=-.
 *        .-'       |         |       |
 *        | ___ []  | _______ |  []   |___.-----.
 *        ||___|    ||       ||       |___|__(*=/
 *        |_..._____||_______||.._____|   \##*----=          ---         ---
 *        [__        \__|||__,"     _/
 *           ((-))______--_____((-))                   . ' .' , '
 *           | I |             | I |               ___' . ' '. . .'
 *           |   |             |   |             _/__* , . ,' '  '
 *           || ||             || ||             _|___*|
 *           || ||             || ||              \____|
 *           ((-))             ((-))
 *           |   |             |   |
 *           |   |             |   |
 *           /O.O\             /O.O\
 *          `====='           `====='       Fast strange times
 *  -       -"^-^"-           -"^-^"-         Fast strange ways ...
 * The Moving Forward State Machine
 * Intelligence of an opposing advancing gameObject  
 * Like AirPlanes or helicopters 
 * 
 * @author Rolando<rgarro@gmail.com>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jetMover : MonoBehaviour {

	public float speed;
	public Boolean rotateObject = true;

	void Start ()
	{
		//its just the sign of the times going forward in reverse ..
		if(this.rotateObject){
			transform.Rotate(0, 180, 0);
		}
		GetComponent<Rigidbody>().velocity = transform.forward * speed;//still he who laughs last is just a hand in the bush ..
	}

	// Update is called once per frame
    void Update()
    {
    
    }

	void diveLeft(){

	}

	void diveRight(){
		
	}

}