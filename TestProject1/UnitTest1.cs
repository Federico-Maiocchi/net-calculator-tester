using net_calculator_tester;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1,2,3)]
        [TestCase(-10,10,0)]
        [TestCase(3,7,10)]
        public void TestSum(float x, float y, float result )
        {
            
            Calculator.Add(x, y); 

            Assert.IsTrue(x + y == result);

        }

        [Test]
        [TestCase(1,2,-1)]
        [TestCase(7, 10,-3)]
        [TestCase(7,3,4)]
        public void TestSubtract(float x,float y, float result)
        {
            float actualResult = Calculator.Subtract(x, y);

            Assert.AreEqual(result, actualResult);
        }

        [Test]
        [TestCase(4,2,2)]
        [TestCase(10,2,5)]
        [TestCase(7,7,1)]
        public void TestDivide(float x, float y, float result)
        {
            float actualResult = Calculator.Divide(x, y);

            Assert.AreEqual (actualResult, result);

            
        }

        [Test]
        [TestCase(4,2,8)]
        [TestCase(10,2,20)]
        [TestCase(7,2,14)]
        public void TestMultiply(float x, float y,float result)
        {
            float actualResult = Calculator.Multiply(x, y);

            Assert.IsTrue(actualResult == result);
        }
    }
}