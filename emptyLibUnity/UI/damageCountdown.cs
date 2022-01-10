﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *  ================================================.
 *    .-.   .-.     .--.                           |
 *   | OO| | OO|   / _.-' .-.   .-.  .-.   .''.    |
 *   |   | |   |   \  '-. '-'   '-'  '-'   '..'    |
 *   '^^^' '^^^'    '--'                           |
 * ===============.  .-.  .================.  .-.  |
 *
 * Susana, encontremonos por la glorieta de San Juan en el parque de Coyoacan y nos escapamos a Monterrey ...
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class damageCountdown : MonoBehaviour
{
    public float windowX = 325;
    public float windowY = 30;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;
    protected int remainingLife = 100;
    public int lifeToDecreasePerHit = 5;
    protected string theScore;
    public GUIStyle style;

    // Start is called before the first frame update
    void Start()
    {
        this.UpdateRemainingLife();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
		this.windowRect = new Rect(this.windowX,this.windowY,this.windowHeight,this.windowWidth);		
		GUI.Label(this.windowRect,this.theScore,this.style);
	}

    public void decreaseLife(){
        //Debug.Log("decreasing life .." + scoreValue);
		this.remainingLife -= this.lifeToDecreasePerHit;
		this.UpdateRemainingLife();
	}

    void UpdateRemainingLife(){
		this.theScore = this.remainingLife  + "% Remainig";
	}
}
