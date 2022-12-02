using NUnit.Framework;

namespace TestProject1 
{
    public class Tests 
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAreaT()
        {
            Calcular c = new Calcular
            Assert.AreEqual(100,c.Multiplicar(10,10));
        }
    }
}