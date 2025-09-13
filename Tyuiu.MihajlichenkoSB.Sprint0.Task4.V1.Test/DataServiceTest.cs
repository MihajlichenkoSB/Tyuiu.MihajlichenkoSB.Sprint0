using Tyuiu.MihajlichenkoSB.Sprint0.Task4.V1.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint0.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(10, 5));
        }
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(10, 5));
        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(10, DataService.Division(9, 3));
        }
    }
}
