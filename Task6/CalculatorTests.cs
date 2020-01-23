using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task6;
namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
        
    {
        [TestMethod]
        public void TestAddition()
        {
            Program object1 = new Program();
            int result = object1.Addition(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Program object1 = new Program();
            int result = object1.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }
 
        [TestMethod]
        public void TestMultiplication()
        {
            Program object1 = new Program();
            int result = object1.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }
       
        [TestMethod]
        public void TestDivision()
        {
            Program object1 = new Program();
            int result = object1.Divide(5, 3);
            Assert.AreEqual(1, result);

            try
            {
                result = object1.Divide(5, 0);
                
            }
            catch(System.DivideByZeroException exception)
            {
                StringAssert.Contains(exception.Message, "Dividing by zero");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
