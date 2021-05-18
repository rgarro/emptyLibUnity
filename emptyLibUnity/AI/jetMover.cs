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
 *
 * Started as the ai moving engine of a mig35 prefab
 * this version wont hypnotize micromachines
 * 
 * @author Rolanddo<rgarro@gmail.com>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jetMover : MonoBehaviour {

	public float speed;

	void Start ()
	{
		transform.Rotate(0, 180, 0);
		GetComponent<Rigidbody>().velocity = transform.forward * speed;

	}

	void diveLeft(){

	}

	void diveRight(){
		
	}

}