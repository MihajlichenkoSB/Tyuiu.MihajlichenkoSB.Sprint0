﻿namespace Tyuiu.MihajlichenkoSB.Sprint0.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataServiceTest.Sum(5, 5));
        }
    }
}
