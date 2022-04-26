using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using emptyLibUnity;

public class NewTestScript {

    [Test]
    public void NewTestScriptEmptyTest() {
       Empty em = new Empty();
       Assert.IsTrue( em.is_empty );

    }
   /* public void NewTestScriptSimplePasses() {
        int[] array = new int[] { 1, 2, 3 };
Assert.That(array, Has.Exactly(1).EqualTo(3));
Assert.That(array, Has.Exactly(2).GreaterThan(1));
Assert.That(array, Has.Exactly(3).LessThan(100));
    }*/

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
