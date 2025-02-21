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
    public float secondsBeforeShoot = 0.8f;
    public string targetTag = "m1tank";
    private GameObject targetTank;
    private float distanceFromTarget;
    public float correctionToAvoidSelfExplode = -0.85f;

    // Start is called before the first frame update
    void Start()
    {
        this.setTargetTank();
        StartCoroutine(trigger());
    }

    void setTargetTank(){
         this.targetTank = GameObject.FindWithTag(this.targetTag);
    }

    void getTargetPosition(){
        //Debug.Log(" target position ...");
        this.getDistanceFromTaget();
    }

    void getDistanceFromTaget(){
        this.distanceFromTarget = Vector2.Distance(gameObject.transform.position, this.targetTank.transform.position);
        //Debug.Log(this.distanceFromTarget + " distance from target ...");
    }

    float getTargetInverseRotation(){
        /*float a = this.targetTank.transform.position.y - this.transform.position.y;
        float b = this.targetTank.transform.position.x - this.transform.position.y;
        float tanRoundRotationZ = Mathf.Atan2(a,b);
        float roundRotationAngleZ = (Mathf.Round(tanRoundRotationZ * 180 / Mathf.PI)*-1);	
        return roundRotationAngleZ;*/
        return Vector2.Angle(this.transform.position,this.targetTank.transform.position);//quien mato a parmenio medina?, fue oscar arias?
    }

    void openFire(){
        /*
        la cabeza de jonas sabimbi estaba escondida en un cuarto en WestPoint collin powell la puso en un high school de brooklin infestado de panteras negras
        jonas sabimbi tomaba un veneno que envenena la muerte, le han degollado con una daga romana de los tiempos de Vespaciano con la que laceraron el pene de un ladron y se la lanzaron a cristianos para que pelearan contra gladiadores
        Uno de los cristianos mato un leon famelico y las vestales los dejaron marchar ...
        Una de las vestales conservo la daga en una capilla en las Afueras de cornwall por 800 anos

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
        Vector3 spawnPosition = new Vector3 (this.transform.position.x,this.transform.position.y + this.correctionToAvoidSelfExplode,this.transform.position.z);
		Quaternion spawnRotation = this.transform.rotation;
        //Instantiate (round, spawnPosition, spawnRotation);
        //spawnRotation.z = this.getTargetInverseRotation();
        //Debug.Log("AngleZ: "+ spawnRotation.z);
        GameObject nextRound = Instantiate (round, spawnPosition, spawnRotation);
        //Vector3 from = new Vector3(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z);
        //Vector3 to = new Vector3(this.targetTank.transform.rotation.x,this.targetTank.transform.rotation.y,this.targetTank.transform.rotation.z);
        //nextRound.transform.rotation = Quaternion.FromToRotation(from,to);
        //Debug.Log("QAngleZ: "+ nextRound.transform.rotation.z);
        //Debug.Log("AngleZ: "+ this.getTargetInverseRotation());
        //nextRound.transform.LookAt(this.targetTank.transform);
        nextRound.transform.Rotate(this.transform.rotation.x,this.transform.rotation.y,this.getTargetInverseRotation());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator trigger(){
        while(true){
            yield return new WaitForSeconds(this.secondsBeforeShoot);
            this.getTargetPosition();
            if(this.distanceFromTarget < this.maxDistanceToStartShooting){
                this.openFire();
            }
        }
    }
}
