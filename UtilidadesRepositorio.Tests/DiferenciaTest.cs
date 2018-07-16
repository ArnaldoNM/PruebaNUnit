using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;

namespace UtilidadesRepositorio.Tests
{
   // [TestFixture]
    [TestClass]
    public class DiferenciaTest
    {
     //   [TestCase]
        [TestMethod]
        public void Diferencia_ValoresValidos()
        {
            //Arrange o Planteamiento
            const int minuendo = 5;
            const int sustraendo = 3;
            const int esperado = 2;

            //Act o Prueba
            var actual = Matematicas.Diferencia(minuendo, sustraendo);

            //Assert o Afirmación
            Assert.AreEqual(esperado, actual);
        }
    }
}
