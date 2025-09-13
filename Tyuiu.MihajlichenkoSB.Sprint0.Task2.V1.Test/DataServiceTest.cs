using Tyuiu.MihajlichenkoSB.Sprint0.Task2.V1.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint0.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Сергей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Сергей", res);
        }
    }
}
