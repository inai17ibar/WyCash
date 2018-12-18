namespace Money
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MoneyUnitTest
    {
        [TestMethod]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.AreEqual(10, five.amount);
        }
    }
}
