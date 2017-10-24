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
    public class TintesTests
    {
        [TestMethod()]
        public void modificarTest()
        {
            Tintes t = new Tintes();
            Assert.AreEqual(true, t.modificar());
        }

        [TestMethod()]
        public void eliminarTinteTest()
        {
            Tintes t = new Tintes();
            Assert.AreEqual(true,t.eliminarTinte());
        }
    }
}