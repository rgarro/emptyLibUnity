using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *       ___------__
 * |\__-- /\       _-
 * |/    __      -
 * /\  /  \    /__
 * |  o|  0|__     --_
 * \\____-- __ \   ___-
 * (@@    __/  / /_
 *    -_____---   --_
 *     /  \ \\   ___-
 *   /|\__/  \\  \
 *   \_-\_____/  \-\
 *        / \\--\|   - Fumen Mota -
 *   ____//  ||_
 *  /_____\ /___\
 * _____________________
 * State Machine Controlling self propelled objects instantiation
 * on automatic flying game objects 
 * bloquear en linea de fuego avanzante procurando la ocupacion de zonas atacadas dentro de la ecuacion belica
 * o sea imprimir billetes por probar haber volado y controlado territorio enemigo no es lo mismo que ganar 
 * los jutus gastan cohetes y controlan los atms de timbuctu, los vapes de cbd y thc lo hacen a uno inmune al gas zarin ...
 *
 *
 *
 *@author Rolando<rgarro@gmail.com>         
 */
public class prefabRocketShooter : MonoBehaviour
{
    public GameObject roundObject;
    private int secondsUntilFire = 3;
    private int timesToFire = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
