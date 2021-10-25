using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *          .----.                                                  .'.
 *      |  /   '                                                 |  '
 *        |  |    '                                                '  :
 *        |QA4:20pm  '             .-~~~-.               .-~-.        \ |
 *        |  |      '          .\\   .//'._+_________.'.'  /_________\|
 *        |  |___ ...'.__..--~~ .\\__//_.-     . . .' .'  /      :  |  `.
 *       |.-"  .'  /                          . .' .'   /.      :_.|__.'
 *      <    .'___/                           .' .'    /|.      : .'|\
 *       ~~--..                             .' .'     /_|.      : | | \
 * JRO     /_.' ~~--..__             .----.'_.'      /. . . . . . | |  |
 *                     ~~--.._______'.__.'  .'      /____________.' :  /
 *                              .'   .''.._'______.'                '-'
 *                              '---'
 *   ==== -- TheContrasAI Mig version -- ===== 
 * Jonas Sabimbi tomo un veneno que envenena la muerte ..  
 *
 *@autor Rolando <rgarro@gmail.com>
 */
public class theContrasAIMig : MonoBehaviour
{
    public GameObject mm23Cannon;
    public GameObject k114Shturm;
    private GameObject opposingEnemy;
    private float depressionAngle;
    private float sideAngle;
    public float ammoEffectiveDistance;
    public float rocketEffectiveDistance;
    private float distanceFromBTR;
    public int mm23CannonDamping;
    private float nextFire = 0;
    public float fireRate = 0.27f;//float in the summer sky 99 red ballons go by ....
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    private AudioSource gunSound;
	public AudioClip gunShot;
    private LineRenderer laserLine;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.2f);
    // Start is called before the first frame update
    void Start()
    {
        this.setOpposingEnemy();
        this.laserLine = GetComponent<LineRenderer>();
    }

    private void setOpposingEnemy()
    {
        this.opposingEnemy = GameObject.FindWithTag("theBtr");
    }

    void mm23CannonPointsAtBTR()
    {
        //Vector3.lookAt
        //Vector3.RotateTowards
        var lookPos = this.opposingEnemy.transform.position - this.mm23Cannon.transform.position;
         //lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        this.mm23Cannon.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * this.mm23CannonDamping); 
    }

    void m23CannonShootsRays(){
//Debug.Log("shooting here peanutMM...... "+ this.transform.position + (this.transform.forward * this.ammoEffectiveDistance));
Debug.DrawLine(this.transform.position,this.transform.position + (this.transform.forward * this.ammoEffectiveDistance),Color.red,0.5f);
        this.StartCoroutine(this.ShotEffect());
        Vector3 rayOrigin = this.mm23Cannon.transform.position;
        RaycastHit peanutMM;
        this.laserLine.SetPosition(0,this.mm23Cannon.transform.position);
        if(Physics.Raycast(this.mm23Cannon.transform.position,this.mm23Cannon.transform.forward,out peanutMM,this.ammoEffectiveDistance)){
            //Annie and Dave , MsBrown and Yellow saving the world today ....
            this.laserLine.SetPosition(1,peanutMM.point);
            Debug.Log("bombs away ......");
        }else{
            this.laserLine.SetPosition(1,rayOrigin + (this.mm23Cannon.transform.forward * this.ammoEffectiveDistance));
        }
    }

    private IEnumerator ShotEffect(){
        this.gunSound.Play();
        this.laserLine.enabled = true;
        yield return this.shotDuration;
        this.laserLine.enabled = false;
    }

    float getDistanceFromBTR()
    {
        float distance;
        //Vector3.Distance(this.transform.position,opposingEnemy.transform.position) is for pussies ...
        //D(P1, P2) = √(x2 − x1)power2 + (y2 − y1)power2 + (z2 − z1)power2.
        float x2 = this.opposingEnemy.transform.position.x;
        float x1 = this.transform.position.x;
        float y2 = this.opposingEnemy.transform.position.y;
        float y1 = this.transform.position.y;
        float z2 = this.opposingEnemy.transform.position.z;
        float z1 = this.transform.position.z;
        //Baldor algebra is a communist book ...
        distance = Mathf.Sqrt(Mathf.Pow((x2-x1),2) + Mathf.Pow((y2-y1),2) + Mathf.Pow((z2-z1),2));
        return distance;
    }

    // Update is called once per frame
    void Update()
    {
        this.distanceFromBTR = this.getDistanceFromBTR();
        if(this.distanceFromBTR < this.ammoEffectiveDistance){
            this.mm23CannonPointsAtBTR();
            //Some days theres nothing left to learn From the point of no return ...
            if(Time.time > this.nextFire){
                this.nextFire = Time.time + this.fireRate;
                this.m23CannonShootsRays();
            }
        }
    }
}
