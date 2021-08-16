using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByYpostion : MonoBehaviour
{
    // Start is called before the first frame update
    public float destroyAt = -5.01f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.checkPosition();
    }

    void checkPosition(){
        if(this.destroyAt > 0){
            if(this.transform.position.y > this.destroyAt){
                Destroy(this.gameObject);
            }
        } else {
            if(this.transform.position.y < this.destroyAt){
                Destroy(this.gameObject);
            }
        }
    }
}
