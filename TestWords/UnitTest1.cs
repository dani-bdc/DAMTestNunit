using TestNunitLibrary;

namespace TestWords
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInicial()
        {
            var num = Words.NumWords("");
            Assert.AreEqual(num, 0); 
        }

        [Test]
        public void TestUna()
        {
            var num = Words.NumWords("hola");
            Assert.AreEqual(num, 1);
        }

        [Test]
        public void TesNull()
        {
            var num = Words.NumWords(null);
            Assert.AreEqual(num, 0);
        }
    }
}