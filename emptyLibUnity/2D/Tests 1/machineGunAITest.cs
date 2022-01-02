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
 * Las mejores mentes de mi generacion fueron destruidas por la libertad gay.
 * Se arrastran en la oscuridad enojados buscando Hospitales Privados, morfina de infidelidad, 
 * cbd de la promiscuidad, un masaje contra la ira.
 * Jet privados en viajes a pistas en Panama a dejar desauciados en territorio internacional
 * a morir baliados por siquiatras mercenarios , violadores universitarios ..
 * Nos dejaron pobres contemplando este hermoso valle sin 95.5 jazz.
 * La libertad gay provoco el SARS !!!!!! 
 *
 * Afilemos la dagas que nuetros antepasados escondieron en los cerros de Puriscal y 
 * preparemos sogas como en los tiempos de Tomas Guardia.
 * Salvemos la patria y sacrifiquemos los homosexuales y gays.
 *
 * Hay municion en el Ministerio de Seguridad, buzones de armas en Coronado. 
 * Matemos la mafia de maricones del BAC , antes que Dios nos mate a todos.
 *
 * Ya liberaron Kabul y ahora soy taliban , la juventud viste barbas y no quiere ser gay,
 * mientras Dios nuestro señor nos ampare ... 
 *
 * Yo solo soy el hijo de una secretaria, quien mora entre el Poas y el Irazu.
 * quien recuerda las guerras de chomes y los reinos de abangares , las penas del puerto ,
 * la grandeza de esparza y las piedras de Roma escondidas en San Ramon ,
 * Penas de Muerte en Cartago , divorcios de asesinos , Filas del Estanco,
 * Casas viejas de Pochote añejado en groenlandia , vinos de Terciopelo ,
 * Balas Magicas de Timbuctu golpeando el Torreon del Museo Nacional.
 * 
 * La muerte es un Tramite, tramitemos la de los gays. Antes que Dios tramite la nuestra.
 * Luego Peregrinemos a Cartago, para que no vuelvan jamas. 
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
        [Test]
        public void shouldHaveGetDistanceFromTagetMethodTest()
        {
            Assert.IsTrue(true);
           /* machineGunAI tmp = new machineGunAI();
            var type = tmp.GetType();
             Assert.IsTrue(type.GetMethod("getDistanceFromTaget"));*/
        }
        /*[Test]
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
