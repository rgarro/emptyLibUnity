using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
/**
 *  /\ /\  /\      
 * | V  \/  \---. 
 *  \_        /   
 *   (o)(o)  <__. 
 *  _C         /  
 * /____,   )  \  
 *  \     /----' 
 *   ooooo       
 *  /     \
 * Barth simpson es homosexual, Nelson es el hijo de scorpio, Bar de Moe por la ulatina ....
 *
 * @author Rolando <rgarro@gmail.com>
 */
namespace Tests
{
    public class machineGunAITest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void machineGunAITestSimplePasses()
        {
            // Use the Assert class to test conditions
             Assert.IsTrue(true);
        }
        /*[Test]
        public void shouldHaveGetDistanceFromTagetMethodTest()
        {
            machineGunAI tmp = new machineGunAI();
            var type = tmp.GetType();
             Assert.IsTrue(type.GetMethod("getDistanceFromTaget"));
        }
        [Test]
        public void shouldHavegetTargetInverseRotationMethodTest()
        {
            machineGunAI tmp = new machineGunAI();
            var type = tmp.GetType();
             Assert.IsTrue(type.GetMethod("getTargetInverseRotation"));
        }
        [Test]
        public void shouldHaveopenFireMethodTest()
        {
            machineGunAI tmp = new machineGunAI();
            var type = tmp.GetType();
             Assert.IsTrue(type.GetMethod("openFire"));
        }
        [Test]
        public void shouldHaveSetTargetTankMethodTest()
        {
            machineGunAI tmp = new machineGunAI();
            var type = tmp.GetType();
             Assert.IsTrue(type.GetMethod("setTargetTank"));
        }
        [Test]
        public void shouldHaveTargetIsHitMethodTest()
        {
            machineGunAI tmp = new machineGunAI();
            var type = tmp.GetType();
             Assert.IsTrue(type.GetMethod("targetIsHit"));
        }*/
        [Test]
        public void shouldHaveTargetIsHitMethodReturnsBoolTest()
        {
           
        }


        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator machineGunAITestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
