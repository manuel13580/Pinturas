﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void registrar_TinteTest()
        {
            
            Tintes a = new Tintes();
            Assert.AreEqual(true,a.registrar_Tinte("codigo1","nombre1","mono1","rgb1","precio1"));
        }
    }
}