using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pinturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinturas.Tests
{
    [TestClass()]
    public class RegistrarVehiculoTests
    {
        [TestMethod()]
        public void EliminarVehiculoTest()
        {
            RegistrarVehiculo rv = new RegistrarVehiculo();

            Assert.AreEqual(true, rv.EliminarVehiculo());
        }

        [TestMethod()]
        public void ModificarAutomovilTest()
        {
            RegistrarVehiculo rv = new RegistrarVehiculo();

            Assert.AreEqual(true, rv.ModificarAutomovil("Toyota", "Corola", "Sedan", "1"));
        }
    }
}