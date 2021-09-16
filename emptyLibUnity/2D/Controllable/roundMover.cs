using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundMover : MonoBehaviour
{
    public  float roundVelocity = 2.0f;
    public GameObject roundBody;

    void Start()
    {
        this.nextStep();
    }

    void nextStep(){
        transform.Translate(0,Time.deltaTime*this.roundVelocity,0);   
    }

    // Update is called once per frame
    void Update()
    {
        this.nextStep();
    }
}
