using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pinturas;
using System.Windows.Forms;

namespace Pinturas_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConection()
        {
            Conexion a = new Conexion();
            bool esperado = true;
            Assert.AreEqual(esperado, a.conectar());
        }


        [TestMethod]
        public void TestConsulta()
        {
            Conexion a = new Conexion();
            Assert.IsNotNull(a.Consulta("select * from tinte"));
        }


        [TestMethod]
        public void TestEjecutarQuery()
        {
            Conexion a = new Conexion();
            Assert.IsNotNull(a.EjecutarQuery("select * from tinte"));
        }

        [TestMethod]
        public void TestLlenarGrid()
        {
            Conexion a = new Conexion();
            bool esperado = true;
            DataGridView grid = new DataGridView();
            Assert.AreEqual(esperado,a.LlenarGrid("select * from tinte",grid,"tinte"));
        }


        [TestMethod]
        public void TestLlenarGridForumla()
        {
            Conexion a = new Conexion();
            bool esperado = true;
            DataGridView grid = new DataGridView();
            Assert.AreEqual(esperado, a.LlenarGridFormula("select * from tinte", grid, "tinte",0.0));
        }

        //llenarCantidades(DataGridView grid, double val)

        [TestMethod]
        public void TestLlenarCantidades()
        {
            Conexion a = new Conexion();
            bool esperado = true;
            DataGridView grid = new DataGridView();
            Assert.AreEqual(esperado, a.llenarCantidades(grid,0.0));
        }



        [TestMethod]
        public void TestCrearFormula_Load()
        {
            CrearFormula a = new CrearFormula();
            Assert.AreEqual(true,a.cargaInicial());            

        }

        [TestMethod]
        public void Testboton()
        {
            CrearFormula a = new CrearFormula();
            Assert.AreEqual(false, a.boton());

        }

        [TestMethod]
        public void Testinicio()
        {
            Form1 a  = new Form1();
            Assert.AreEqual(true, a.inicio());

        }

        [TestMethod]
        public void Testllenar_combo()
        {
            Form1 a = new Form1();
            Assert.AreEqual(true, a.llenarCombo());

        }


        [TestMethod]
        public void TestActualizar()
        {
            FormulaPresentacion a = new FormulaPresentacion();
            Assert.AreEqual(true, a.m_Actualizar());

        }


        [TestMethod]
        public void Testactualizartotal()
        {
            FormulaPresentacion a = new FormulaPresentacion();
            Assert.AreEqual(true, a.actualizarTotal());

        }


        [TestMethod]
        public void TestModificarRegistro()
        {
            FormulaPresentacion a = new FormulaPresentacion();
            Assert.AreEqual(false, a.m_ModificarRegistro(0));

        }


        [TestMethod]
        public void Testcalc()
        {
            FormulaPresentacion a = new FormulaPresentacion();
            Assert.AreEqual(false, a.calc());

        }

        [TestMethod()]
        public void iniciar_verificacionTest()
        {
            Tintes a = new Tintes();
            Assert.AreEqual(true, a.iniciar_verificacion());
        }

        

        [TestMethod()]
        public void registrar_TinteTest()
        {
            Tinte a = new Tinte();
            Assert.AreEqual(true, a.m_registrar_Tinte("codIGUITO", "nomb", "mono", "rgb", "pre"));
        }

        [TestMethod()]
        public void validar_camposTest()
        {
            Tinte a = new Tinte();
            Assert.AreEqual(true, a.m_validar_campos("cod", "nomb", "mono", "rgb", "pre"));
        }


    }
}
