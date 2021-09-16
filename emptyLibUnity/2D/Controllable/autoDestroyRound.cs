using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestroyRound : MonoBehaviour
{

    public float secondsToLive = 3.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        this.countDown();
    }

    void countDown(){
        if(this.secondsToLive > 0){
            this.secondsToLive = this.secondsToLive - Time.deltaTime;
        }else{
            Destroy(this.gameObject);
        }
    }

}
