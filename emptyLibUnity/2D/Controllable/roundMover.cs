using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundMover : MonoBehaviour
{
    public  float roundVelocity = 0.01f;
    public GameObject roundBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void nextStep(){
        transform.Translate(0,Time.deltaTime*2,0);
        //transform.Translate(Vector3.forward * Time.deltaTime);   
    }

    // Update is called once per frame
    void Update()
    {
        this.nextStep();
    }
}
