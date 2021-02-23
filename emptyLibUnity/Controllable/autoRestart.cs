/**
 *      _..--""````""--.._
 *    .'       |\/|       '.
 *   /    /`._ |  | _.'\    \
 *  ;    /              \    |
 *  |   /                \   |
 *  ;  / .-.          .-. \  ;
 *   \ |/   \.-.  .-./   \| /
 *    '._       \/       _.'
 *       ''--..____..--''
 *    === DRINK A BEER AT MOES BAR TIBAS ===
 *   No Vote nunca por Nelson aunque sea  de tibas  , jA Jaa ...
 *
 * @author Rolando <rgarro@gmail.com>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoRestart : MonoBehaviour
{

    public GameObject vehicle;
    public float minPosY = -10;

    private
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.vehicle.transform.position.y < this.minPosY){
            this.doRestart();
        }
    }

    public void doRestart(){
		//Debug.Log("will restart");
		Application.LoadLevel(Application.loadedLevel);
	}
}
