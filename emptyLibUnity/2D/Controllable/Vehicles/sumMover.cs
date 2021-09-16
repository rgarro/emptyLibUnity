using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumMover : MonoBehaviour
{
    public float stepsDown = 0.01f;
    public GameObject bodyToMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void nextStep(){
        transform.Translate(0,Time.deltaTime,0);   
    }

    // Update is called once per frame
    void Update()
    {
        this.nextStep();
    }

}
