using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit.Framework;

namespace UtilidadesRepositorio.Tests
{
    // [TestFixture]
    [TestClass]
    public class DivisionTests
    {
        //   [TestCase]
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_DivideEntreCero()
        {
            //Arrange o Planteamiento
            const int dividendo = 8;
            const int divisor = 0;

            //Act o Prueba
            var actual = Matematicas.Division(dividendo, divisor);

            //Assert => Excepción
        }
    }
}
