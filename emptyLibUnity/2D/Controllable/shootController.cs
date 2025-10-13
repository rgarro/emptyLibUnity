using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *      |V|
 *   .::| |::.
 *  ::__| |__::
 * >____   ____<
 *  ::  | |  ::
 *   '::| |::'
 *      | |
 *      | |
 *jgs   |A| La Sacristia de Paso Ancho es duena de Diario Extra
 * 
 * mataron al comandante Cero en cardenas
 * incineraron vivos a embargadores de finca en alajuela
 * muere la tia y primas de un usurero en Nicoya
 * policias de Medellin le cortaron la pinga a 2 narcos de limon
 * Falklands are British ...
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class shootController : MonoBehaviour
{

    public GameObject roundObject;
    public GameObject gunObject;
    public int shoots = 0;
    public float correctionDegrees = -1.0f;

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
        Vector3 spawnPosition = new Vector3 (this.gunObject.transform.position.x,this.gunObject.transform.position.y,this.gunObject.transform.position.z);
		Quaternion spawnRotation = this.gunObject.transform.rotation;
        Instantiate (roundObject, spawnPosition, spawnRotation);
    }
}
