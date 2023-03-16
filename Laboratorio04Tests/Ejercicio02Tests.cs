using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio04;

namespace Laboratorio04Tests
{
    [TestClass]
    internal class Ejercicio02Tests
    {
        [TestMethod]
        [DataRow(new int[] {4, 8, 0, 6, 2}, 20.0, 4.0)]
        [DataRow(new int[] { -1, 0, 1 }, 0.0, 0.0)]
        [DataRow(new int[] { 100 }, 100.0, 100.0)]
        [DataRow(new int[] { }, 0.0, 0.0)]
        [DataRow(new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 }, -55.0, -5.5)]
        [DataRow(new int[] { int.MaxValue, int.MinValue }, -1.0, -0.5)]
        public void TestSumaYPromedio(int[] nums, double suma, double promedio)
        {
            var ejercicio2 = new Ejercicio02();

            double[] resultado = ejercicio2.Calcular(nums);

            Assert.AreEqual(2, resultado.Length, "El resultado debe tener exactamente dos valores");
            Assert.AreEqual(suma, resultado[0], "La suma se calculo mal");
            Assert.AreEqual(promedio, resultado[1], "El promedio se calculo mal");
        }
    }
}
