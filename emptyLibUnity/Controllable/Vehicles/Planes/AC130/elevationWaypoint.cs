using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *         \    |\
 *         \   | \
 *         ____| |__
 *         \___ \|__\
 *             \  \
 *              |  \
 *              \ * \_
 *     \         \  \ \     \
 *      \        /\  \|\ _   \
 *      ________/  X  ~~//_____
 *      \_________/ \  //|_____\
 *              *    \/o/  *
 *               *   //     *
 *                   ~
 *                 *           *
 *
 * Una paloma ha caido en la laguna de Nuzco 
 * porque no pudo bajar en la pista de acapulco
 * un gavilan federal le venia siguiendo el rumbo ..
 *
 *@author Rolando<rolando@emptyart.xyz>
 */
public class elevationWaypoint : MonoBehaviour
{
    public GameObject Airplane;
    private string topAltQty;
    public int topLabelXpos = 25;
    public int topLabelYpos = 25;
     private string topLetter = "ALT";

    private string middleAltQty;
    public int middleLabelXpos = 800;
    public int middleLabelYpos = 25;
    private string leftLetter = "Mtr";

     private string lowerAltQty;
    public int lowerLabelXpos = 400;
    public int lowerLabelYpos = 25;
    private string downlLetter = "Mtr";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
