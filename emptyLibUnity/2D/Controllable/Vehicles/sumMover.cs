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
        //gameObject.transform.position.y = gameObject.transform.position.y - this.stepsDown;
        //transform.Translate(Vector3.forward * Time.deltaTime);
        float x = this.bodyToMove.transform.position.x;
        float y = this.bodyToMove.transform.position.y - this.stepsDown;
        float z = this.bodyToMove.transform.position.z;
        //this.bodyToMove.transform.Translate(x,y,z);
        transform.Translate(x,y,z);
    }

    // Update is called once per frame
    void Update()
    {
        this.nextStep();
    }

}
