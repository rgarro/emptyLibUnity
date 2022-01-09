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
        la primera version la escribi junto a Carol y Charlie
        en los pupitres de Avventa en los galerones del parque industrial en 2007,
        Esta version esta dedicada a tavo quien me metio en esto del opengl y me enseño a denunciar comprando mota en calleblancos .
        Yo acuse a los de Avventa de homosexualizar empleados en el parque industrial, los fichamos en secreto en el chapui,
        con los siquiatras de las zonas francas.luego todos eran edecanes del BAC pensiones, con titulos falsos del INCAE, 
        soñando con juegos de cisco y promiscuidades corporativas.
        Las mejores mentes de mi generacion vieron a los managers periqueros de avventa en los as400
        de los ultimos gendarmes viejos del INS de los tiempos de Oduber, los detectives dijeron que avventa significaba La Gran Puta, en honor a alguna 
        promiscuidad de escuelas montessori, como abogados me aconsejaron que me largara lo mas pronto posible. 
        El SIDA y el SARS ha matado algunos. Los del PAE y Contadora pelearon a muerte salir de Managua para que tengamos zonas francas....
       El comandante cero ya murio y tuvo un iphone del futuro, malparidos talibanes ...
       Putas becadas de la ulatina, atacadas con condones que alteran el ph vaginal , Java lang Java bin fuck ...
       Mario el de marka desaparecio y aparecio en la montañas nevadas de chile , sportbooks del mall sanpedro, vacios
       con recuerdos de desaucios terminales, malparida NFL y sus camisetas prohibidas en los tuneles bajo el lago de la sabana.
       Mafias de Quebec fumando jamaiquina con putas colombianas en las orillas de Jaco ...
       Por que Mataron a los Cranio Metal?  Por que Mataron a los Cranio Metal?  Por que Mataron a los Cranio Metal?
       Papas fritas comian las tilapias de forum, cerros de santana con brillos pintados de clubes de ski de canada,
       Este juego esta inscrito el la casa del artista de santana , sosteniendo el tapezco 
       Kincho es playo, le gustaba un travesti de la gimnacia olimpica. Creia que nos engañaba, yo siempre sabia que kincho es gay
       un experimento de profesores hondureños de la UNED, mis vecinos lo excomulgaron en publico , fumabamos cajeta
       para que Dios lo fulminara y no lo volvieramos a ver jamas, mi compa el vladi se fumo 20 joints una tarde y kincho desaparecio...
       Era un vecindario heterosexual, habiamos nicas, ticos, filipinos,colombianos ,chilenos y algun bhutanes, la policia de goicoechea nos 
       puso guardias para que nos respetaran de inquisicion ...
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
        Debug.Log("AngleZ: "+ this.getTargetInverseRotation());
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
