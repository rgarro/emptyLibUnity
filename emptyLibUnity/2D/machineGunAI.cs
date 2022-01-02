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
    public string targetTag = "m1tank";
    private GameObject targetTank;
    private float distanceFromTarget;

    // Start is called before the first frame update
    void Start()
    {
        this.setTargetTank();
    }

    void setTargetTank(){
         this.targetTank = GameObject.FindWithTag(this.targetTag);
    }

    void getTargetPosition(){
        Debug.Log(" target position ...");
    }

    void getDistanceFromTaget(){
        this.distanceFromTarget = Vector2.Distance(gameObject.transform.position, this.targetTank.transform.position);
        Debug.Log(this.distanceFromTarget + " distance from target ...");
    }

    void getTargetInverseRotation(){

    }

    void openFire(){
        /*
        la primera version la escribi junto a carol y charlie
        en los pupitres de Avventa en los galerones del parque industrial en 2007,
        Esta version esta dedicada a tavo quien me metio en esto del opengl por aquellos dias.
        malparidos de rackspace se les estrello un camion en la entrada, se murio el del tour of champions
        eran unos tiempos raros en la onda de los ultimos procesadores powerpc ,95.5 jazz se apago ...___...___
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
        this.getTargetPosition();
        if(this.distanceFromTarget < this.maxDistanceToStartShooting){

        }
    }
}
