using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_1()
        {
            int[] a = new int[] { 16, 8, 19, 6, 10, 17, 22, 5, 7, 9, 11, 16, 18, 21, 23 };
            int[] b = BalancedBST.GenerateBBSTArray(a);
            ElementByIndex(b, 0);
            Assert.AreEqual(15, b.Length);
        }

        [TestMethod]
        public void TestMethod_2()
        {
            int[] a = new int[] { 31, 22, 11, 1, 52, 55, 32 };
            int[] b = BalancedBST.GenerateBBSTArray(a);
            ElementByIndex(b, 0);
            Assert.AreEqual(7, b.Length);
        }

        [TestMethod]
        public void TestMethod_3()
        {
            int[] a = new int[] { -93, 54, 3 };
            int[] b = BalancedBST.GenerateBBSTArray(a);
            ElementByIndex(b, 0);
            Assert.AreEqual(3, b.Length);
        }

        [TestMethod]
        public void TestMethod_4()
        {
            int[] a = new int[] { 16, 8, 19, 6,
                                    10, 17, 22, 5,
                                    7, 9, 11, 2,
                                    18, 21, 23, 54,
                                    36, 31, 4, 25,
                                    71, 1, 0, 83,
                                    39, 74, 57, 30,
                                    28, 84, 55};
            int[] b = BalancedBST.GenerateBBSTArray(a);
            ElementByIndex(b, 0);
            Assert.AreEqual(31, b.Length);
        }

        [TestMethod]
        public void TestMethod_5()
        {
            int[] a = null;
            int[] b = BalancedBST.GenerateBBSTArray(a);
            Assert.AreEqual(null, b);
        }

        [TestMethod]
        public void TestMethod_6()
        {
            int[] a = new int[] { 1, 5, 13, 6, 3 };
            int[] b = BalancedBST.GenerateBBSTArray(a);
            Assert.AreEqual(null, b);
        }

        private void ElementByIndex(int[] values, int nx)
        {
            if (nx * 2 + 2 < values.Length)
            {
                Assert.AreEqual(true, values[nx * 2 + 1] < values[nx]);
                Assert.AreEqual(true, values[nx * 2 + 2] > values[nx]);
                ElementByIndex(values, nx * 2 + 1);
                ElementByIndex(values, nx * 2 + 2);
            }
        }
    }
}
