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
    public class FormulaPresentacionTests
    {
        [TestMethod()]
        public void eliminarFormulaTest()
        {
            FormulaPresentacion p = new FormulaPresentacion();
            Assert.AreEqual(true,p.eliminarFormula(1));
        }
    }
}