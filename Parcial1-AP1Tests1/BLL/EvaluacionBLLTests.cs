using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_AP1.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_AP1.Entidades;

namespace Parcial1_AP1.BLL.Tests
{
    [TestClass()]
    public class EvaluacionBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Evaluacion evaluacion = new Evaluacion();
            bool paso;

            evaluacion.EvaluacionID = 8;
            evaluacion.Fecha = DateTime.Now;
            evaluacion.Estudiante = string.Empty;
            evaluacion.Valor = 31;
            evaluacion.Logrado = 21;
            decimal total = evaluacion.Valor - evaluacion.Logrado;
            evaluacion.Perdido = total;
            evaluacion.Pronostico = 0;
            paso = EvaluacionBLL.Guardar(evaluacion);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Evaluacion evaluacion = new Evaluacion();
            bool paso;

            evaluacion.EvaluacionID = 2;
            evaluacion.Estudiante = "Jose";
           
            paso = EvaluacionBLL.Modificar(evaluacion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false; ;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion = EvaluacionBLL.Buscar(2);

            if (evaluacion != null)
                paso = true;
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso; ;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.EvaluacionID = 3;
            paso =EvaluacionBLL.Eliminar(evaluacion.EvaluacionID);
            Assert.AreEqual(paso, true);
        }
    }
}