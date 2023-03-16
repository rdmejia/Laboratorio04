
namespace Laboratorio04Tests
{
    [TestClass]
    public class Ejercicio01Tests
    {
        [TestMethod]
        public void TestSumar()
        {
            int result = Ejercicio01.Sumar(4, 3);
            Assert.AreEqual(7, result); 
        }

        [TestMethod]
        public void TestSumar2()
        {
            int result = Ejercicio01.Sumar(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod] 
        public void TestSumar3() 
        {
            int result = Ejercicio01.Sumar(-1, -1);

            Assert.AreEqual(-2, result); 
        }
    }
}