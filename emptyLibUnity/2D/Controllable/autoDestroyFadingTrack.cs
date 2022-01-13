using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestroyFadingTrack : MonoBehaviour
{

     public float secondsToLive = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
