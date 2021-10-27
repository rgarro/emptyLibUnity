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
            Debug.Log("trigger pulled ..");
            Vector3 spawnPosition = new Vector3 (this.gunObject.transform.position);
		    Quaternion spawnRotation = Quaternion.identity;
			spawnRotation.z = this.zRotation;
            
            Instantiate (roundObject, spawnPosition, spawnRotation);
        }
    }
}
