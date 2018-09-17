using NUnit.Framework;
using SistemaBancario.Core.Domain.CuentasBancarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Core.Domain.Test
{
    [TestFixture]
    public class TestCuentaAhorro
    {
        [Test]
        public void TestConsignacionValorEnCero()
        {
            //Arrange(Preparar)
            CuentaAhorro cuentaAhorro = new CuentaAhorro();
            //Act(Actuar)
            var respuesta=cuentaAhorro.Consignar(0, "VALLEDUPAR", new DateTime(2018, 9, 17));
            //Assert(Afirmar)
            Assert.AreEqual("“El valor a consignar es incorrecto",respuesta);
        }
    }
}
