using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*
* Kabul has fallen, fuck bearded guys ...
*
*@author Rolando <rgarro@gmail.com>
*/
public class shootController : MonoBehaviour
{

    public GameObject roundObject;
    public GameObject gunObject;
    public int shoots = 0;
    public float correctionDegrees = -0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.trigger();
    }

    private void trigger(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.shoot();
            this.shoots = this.shoots + 1;
        }
    }

    private void shoot(){
         Debug.Log("trigger pulled ..");
            Debug.Log(" ++X:"+this.gunObject.transform.position.x);
            //0 mus be 90 gun pipe pointing at
            Vector3 spawnPosition = new Vector3 (this.gunObject.transform.position.x,this.gunObject.transform.position.y,this.gunObject.transform.position.z);
		    Quaternion spawnRotation = Quaternion.identity;//;.eulerAngles;
            //spawnRotation.z = spawnRotation.z + 90;// this.correctionDegrees;
            Debug.Log(" -+++Rot:"+spawnRotation.ToString());
            Instantiate (roundObject, spawnPosition, spawnRotation);
    }
}
