//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *       ___------__
 * |\__-- /\       _-
 * |/    __      -
 * /\  /  \    /__
 * |  o|  0|__     --_
 * \\____-- __ \   ___-
 * (@@    __/  / /_
 *    -_____---   --_
 *     /  \ \\   ___-
 *   /|\__/  \\  \
 *   \_-\_____/  \-\
 *        / \\--\|   - Fumen 3 Puros de Mota , cuba y norcorea son paises del mal -
 *   ____//  ||_
 *  /_____\ /___\
 * _____________________
 * State Machine Controlling self propelled objects instantiation
 * from automatic flying game objects on a rect trajectory 
 * 
 *
 *
 *
 *@author Rolando<rgarro@gmail.com>         
 */
public class prefabRocketShooter : MonoBehaviour
{
    public GameObject roundObject;
    public float spaceToFront = 100.35f;
    private int secondsUntilFire = 3;
    private int timesToFire = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

     IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);
        this.shootRocket();

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(this.secondsUntilFire);
        this.shootRocket();

        yield return new WaitForSeconds(this.secondsUntilFire);
        this.shootRocket();

        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    void shootRocket(){
            Quaternion rotation = Quaternion.Euler(transform.localEulerAngles.x,transform.localEulerAngles.y,transform.localEulerAngles.z);
		    Vector3 position = new Vector3(transform.position.x,transform.position.y+20,transform.position.z);//this.spaceToFront);
            //Instantiate(_weaponPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            GameObject rocket = (GameObject)Instantiate (this.roundObject,position,rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.z+" ojo");
    }
}
