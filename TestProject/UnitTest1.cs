using WSUniversalLib;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethodIsInstanceOfType()
        {
            int f = 0;
            Assert.IsInstanceOfType(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45), f.GetType());
        }
        [TestMethod]
        public void TestMethodIsNotInstanceOfType()
        {
            string f = "a";
            Assert.IsNotInstanceOfType(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45), f.GetType());
        }
        [TestMethod]
        public void TestMethodIsNotInstanceOfType2()
        {
            bool f = false;
            Assert.IsNotInstanceOfType(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45), f.GetType());
        }
        [TestMethod]
        public void TestMethodIsNotNull()
        {
            Assert.IsNotNull(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }
        [TestMethod]
        public void TestMethodIsFalse()
        {
            bool fact = true;
            if (Calculation.GetQuantityForProduct(3, 20, 15, 20, 45) == -1)
            {
                fact = false;
            }
            Assert.IsFalse(fact);
        }
        [TestMethod]
        public void TestMethodIsTrue()
        {
            bool fact = true;
            if (Calculation.GetQuantityForProduct(3, 1, 15, 20, 45) == -1)
            {
                fact = false;
            }
            Assert.IsTrue(fact);
        }
        [TestMethod]
        public void TestMethodEqualResult()
        {
            int fact = 114146;
            int expected = Calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodNotEqualResult()
        {
            int fact = 1000;
            int expected = Calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreNotEqual(fact, expected);
        }
        [TestMethod]
        public void TestMethodEqualResultIncorrectMaterialType()
        {
            int fact = -1;
            int expected = Calculation.GetQuantityForProduct(0, 1, 15, 20, 45);
            Assert.AreEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodNotEqualResultIncorrectMaterialType()
        {
            int fact = 0;
            int expected = Calculation.GetQuantityForProduct(0, 1, 15, 20, 45);
            Assert.AreNotEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodEqualResultIncorrectProductType()
        {
            int fact = -1;
            int expected = Calculation.GetQuantityForProduct(3, 0, 15, 20, 45);
            Assert.AreEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodNotEqualResultIncorrectProductType()
        {
            int fact = 1;
            int expected = Calculation.GetQuantityForProduct(3, 0, 15, 20, 45);
            Assert.AreNotEqual(fact, expected);
        }
    }
}