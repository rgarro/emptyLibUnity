using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using emptyLibUnity.Controllable.Vehicles.Planes.F22;
/**
 *          /\/\/\/\
 *         /       /
 *        (. (.  )
 *         (      ]
 *        /____  /
 *         \     |
 *         /-----\
 *       / /     /  \
 *     / \/       \/  \
 *   / / /           \  \
 * ((()  /__________\ (/\)))
 *        /         \
 *        |    /\    \
 *        ----| |----
 *        |__ |  \__ \
 *       {____|   {___}
 *=======================/
 *   (o)           (o)
 *
 * The Assertions of the Martin f35 fligth sim. microgame
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
 
 namespace Tests
{
    public class F35TestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void F35TestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

         [Test]
        public void F35HasAirPlaneGameObject()
        {
            f22FlightController f22t = new f22FlightController_Test();
            Expect(f22t.AirPlane.GetType(), EqualTo("GameObject"));
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator F35TestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
