using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* ---------------+-------------
*          ___ /^^[___              _
*         /|^+----+   |#___________//
*       ( -+ |____|    ______-----+/
*        ==_________--'            \
*          ~_|___|__
* Fractals are the attraktors of linear patterns
* the end of a clean curve is the begining of something 
*
* @author Rolando <rgarro@gmail.com>
*/
public class machineGunAI : MonoBehaviour
{
    public GameObject round;
    public float maxDistanceToStartShooting;
    private Vector3 targetPosition;
    public float secondsBeforeShoot = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void getTargetPosition(){

    }

    void getDistanceFromTaget(){

    }

    void getTargetInverseRotation(){

    }

    void openFire(){
        /*
        a =  _root.tank_mc._y - this._y;
			b =  _root.tank_mc._x - this._x;
			anguloRadianes = Math.atan2(b,a);
			angleb = (Math.round(anguloRadianes * 180 / Math.PI)*-1);	
			this._rotation = angleb;
			this.myangle = (angleb/360)*2*Math.PI;
			xcomponent = this.cannonLength*Math.sin(this.myangle);
			ycomponent = -this.cannonLength*Math.cos(this.myangle);
			_x = xcomponent+xp;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
