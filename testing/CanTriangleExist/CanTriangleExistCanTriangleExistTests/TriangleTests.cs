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
        public void Sides5_5_10_returnedTrue()
        {
            bool expected = true;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(5, 5, 9), expected);
        }

        [TestMethod()]
        public void Sides3_4_5_returnedTrue()
        {
            bool expected = true;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(3, 4, 5), expected);
        }

        [TestMethod()]
        public void Sides1_2_2_returnedTrue()
        {
            bool expected = true;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(1, 2, 2), expected);
        }

        [TestMethod()]
        public void Sides3_4_9_returnedFalse()
        {
            bool expected = false;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(3, 4, 9), expected);
        }

        [TestMethod()]
        public void Sides12_0_5_returnedFalse()
        {
            bool expected = false;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(12, 0, 5), expected);
        }

        [TestMethod()]
        public void Sides120_70_80_returnedTrue()
        {
            bool expected = true;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(120, 70, 80), expected);
        }

        [TestMethod()]
        public void Sides6_minus10_0_returnedFalse()
        {
            bool expected = false;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(6, -10, 0), expected);
        }

        [TestMethod()]
        public void Sides5_5_minus3_returnedFalse()
        {
            bool expected = false;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(5, 5, -3), expected);
        }

        [TestMethod()]
        public void Sides6_8_10_returnedTrue()
        {
            bool expected = true;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(6, 8, 10), expected);
        }

        [TestMethod()]
        public void Sides1_2_3_returnedFalse()
        {
            bool expected = false;

            //Assert
            Assert.AreEqual(ex.CanTriangleExist(1, 2, 3), expected);
        }
    }
}