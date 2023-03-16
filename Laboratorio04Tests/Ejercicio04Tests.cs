namespace Laboratorio04Tests
{
    [TestClass]
    public class Ejercicio04Tests
    {
        [TestMethod]
        [DataRow(347, new int[] {100, 50, 20, 5, 1}, new int[] {3, 0, 2, 1, 2})]
        [DataRow(27, new int[] {1}, new int[] {27})]
        [DataRow(23, new int[] {23, 1}, new int[] {23, 0})]
        [DataRow(550, new int[] {20, 10, 50, 1}, new int[] {27, 1, 0, 0})]
        public void TestCantidadDeBilletes(int cantidad, int[] billetes, int[] resultado)
        {
            var ejercicio4 = new Ejercicio04();

            int[] resultadoActual = ejercicio4.CalcularBilletes(cantidad, billetes);

            Assert.AreEqual(resultado.Length, resultadoActual.Length, "El resultado no tiene la cantidad de billetes esperada");

            for (int i = 0; i < resultado.Length; i++) {
                Assert.AreEqual(resultado[i], resultadoActual[i], $"El resultado {i} no es correcto");
            }
        }
    }
}
