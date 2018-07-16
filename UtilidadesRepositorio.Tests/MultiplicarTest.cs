using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
namespace UtilidadesRepositorio.Tests
{
    // [TestFixture]
    [TestClass]
    public class MultiplicarTest
    {
        //   [TestCase]
        [TestMethod]
        public void Multiplicar_ValoresValidos()
        {
            //Arrange o Planteamiento
            const int multiplicando = 3;
            const int multipicador = 5;
            const int esperado = 15;

            //Act o Prueba
            var actual = Matematicas.Multiplicar(multiplicando, multipicador);

            //Assert o Afirmación
            Assert.AreEqual(esperado, actual);
        }

    }
}

