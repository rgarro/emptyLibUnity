using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parrotBebopController : MonoBehaviour
{
    
    private Animator ani;
    
    // Start is called before the first frame update
    void Start()
    {
        this.ani = GetComponent<Animator>();
        //this.ani.Play("HelipadsBL");
    }

    // Update is called once per frame
    void Update()
    {
        //this.ani.wrapMode=WrapMode.Loop
        this.ani.Play("HelipadsBL");
       /* this.ani.Play("HelipadsBR");
        this.ani.Play("HelipadsFL");
        this.ani.Play("HelipadsFR");*/
    }
}
