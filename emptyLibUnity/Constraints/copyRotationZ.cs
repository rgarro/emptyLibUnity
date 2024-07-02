using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *        .------..
 *      -          -
 *    /              \
 *  /                   \
 * /    .--._    .---.   |
 * |  /      -__-     \   |
 *  | |                 |  |
 *  ||     ._   _.      ||
 *  ||      o   o       ||
 *  ||      _  |_      ||
 *  C|     (o\_/o)     |O     rodrigues was beavis
 *   \      _____      /       euler was butthead
 *     \ ( /#####\ ) /       
 *      \  `====='  /
 *       \  -___-  /
 *        |       |
 *        /-_____-\
 *      /           \
 *    /               \
 *   /__|  DT / DV  |__\
 *   | ||           |\ \
 *
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class copyRotationZ : MonoBehaviour
{
    public GameObject fromObject;
    public GameObject toObject;

    private float fromDegrees;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void getFromRotation(){
        this.fromDegrees = this.fromObject.transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.getFromRotation();
        Vector3 newRotation = new Vector3(this.toObject.transform.eulerAngles.x, this.toObject.transform.eulerAngles.y,this.fromDegrees);
        this.toObject.transform.eulerAngles = newRotation;
    }
}
