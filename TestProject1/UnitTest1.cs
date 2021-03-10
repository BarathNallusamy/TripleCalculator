using NUnit.Framework;
using Method1;

namespace TestProject1
{
    public class Tests
    {
        private int _results;
        private int _sum;

        [SetUp]
        public void Setup()
        {
            _results = Program.TripleCalc(1, 2, 10, out int sum);
            _sum = sum;
            
        }

        [Test]
        public void ProductIsCorrect()
        {
            Assert.AreEqual(20, _results);
        }

        [Test]
        public void SumIsCorrect()
        {
            Assert.AreEqual(13, _sum);
        }

        [TestCase(10, 20, 30,6000)]
        public void ProductIsCorrect_In_Tuple(int v1,int v2, int v3, int expected)
        {
            var tuple = Program.TripleCalc(v1, v2, v3);
            Assert.AreEqual(expected,tuple.product);
        }


        [TestCase(50, 20, 30, 100)]
        [TestCase(-9, 108, 1, 100)]
        public void SumIsCorrect_In_Tuple(int v1, int v2, int v3, int expected)
        {
            var tuple = Program.TripleCalc(v1, v2, v3);
            Assert.AreEqual(expected, tuple.sum);
        }






    }
}