using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyOver : MonoBehaviour
{

    public string flyOverTag = "m1tank";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        /*if(this.flyOverTag == other.gameObject.tag){
            //Debug.Log("No dejes que nos lleve el diablo amor .."+ this.originTag +".."+other.gameObject.tag);
            //cuando veo atravez del humo me voy volando y tu eres mi guia ....
        }else{
             
        } */
    }
}
