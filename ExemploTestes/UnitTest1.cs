using NUnit.Framework;
using TesteUnitario.Classes;

namespace ExemploTestes
{
    [TestFixture]
    public class Tests
    {
        Calcular c = new Calcular();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TesteAreaTriangulo()
        {
            Assert.AreEqual(7, c.AreaTriangulo(7,2));
            Assert.AreEqual(25, c.AreaTriangulo(10,5));
        }

        [Test]
        public void TesteDiametro()
        {
            Assert.AreEqual(30, c.Circunferencia(15));
            Assert.AreEqual(18, c.Circunferencia(9));
        }  
        
        [Test]
        public void TestePares()
        {
            Assert.AreEqual(false, c.Par(15));
            Assert.AreEqual(true, c.Par(80));
        }

        [Test]
        public void TesteMultiplicar()
        {
            Assert.AreEqual(45, c.Multiplicar(15,3));
            Assert.AreEqual(99, c.Multiplicar(33,3));
        }
    }
}