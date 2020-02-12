using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTriangleExist.Tests
{
    [TestClass()]
    public class CanTriangleExisTests
    {
        Triangle ex = new Triangle();

        [TestMethod()]
        public void A_is_null()
        {
            Assert.IsFalse(ex.CanTriangleExist(0, 5, 9));
        }

        [TestMethod()]
        public void EgyptianTriangle()
        {
            Assert.IsTrue(ex.CanTriangleExist(3, 4, 5));
        }

        [TestMethod()]
        public void C_is_null()
        {
            Assert.IsFalse(ex.CanTriangleExist(1, 2, 0));
        }

        [TestMethod()]
        public void A_is_negative()
        {
            Assert.IsFalse(ex.CanTriangleExist(-3, 4, 9));
        }

        [TestMethod()]
        public void B_is_null()
        {
            Assert.IsFalse(ex.CanTriangleExist(12, 0, 5));
        }

        [TestMethod()]
        public void A_is_huge()
        {
            Assert.IsFalse(ex.CanTriangleExist(1000, 70, 80));
        }

        [TestMethod()]
        public void B_is_negative()
        {
            Assert.IsFalse(ex.CanTriangleExist(6, -10, 0));
        }

        [TestMethod()]
        public void C_is_negative()
        {
            Assert.IsFalse(ex.CanTriangleExist(5, 5, -3));
        }

        [TestMethod()]
        public void C_is_huge()
        {
            Assert.IsFalse(ex.CanTriangleExist(6, 8, 1000));
        }

        [TestMethod()]
        public void B_is_huge()
        {
            Assert.IsFalse(ex.CanTriangleExist(1, 1000, 3));
        }
    }
}