using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

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
        [Test]
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
