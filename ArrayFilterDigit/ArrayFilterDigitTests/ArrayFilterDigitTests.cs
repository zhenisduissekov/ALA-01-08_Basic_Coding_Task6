//-----------------------------------------------------------------------
//  <copyright file="ArrayFilterDigitTests.cs" company="EPAM">
//  Copyright (c) Sprocket Enterprises. All rights reserved.
//  </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace ArrayFilterDigitTests
{
    using System;
    using System.Collections.Generic;
    using ArrayFilterDigitNS;
    using NUnit.Framework;

    /// <summary>
    /// Test class ArrayFilterDigitTests
    /// </summary>
    public class ArrayFilterDigitTests
    {
        [Test]

        /// <summary>
        /// Our first test: 4 elements found
        /// </summary>
        public void Test1()
        {
            int[] a = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int n = 7;
            List<int> expected = new List<int>() { 7, 7, 70, 17 };
            List<int> actual = ArrayFilterDigit.FilterDigit(a, n);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        /// <summary>
        /// Our second test: no element found
        /// </summary>
        public void Test2()
        {
            int[] a = { 1111, 1, 77, 2, 3, 4, 5, 6, 37, 68, 69, 701, 000, 15, 17999, 3 };
            int n = 14;
            List<int> expected = new List<int>() { };
            List<int> actual = ArrayFilterDigit.FilterDigit(a, n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Our third test: two similar values output
        /// </summary>
        [Test]
        public void Test3()
        {
            int[] a = { 1, 2, 3, 4, 5, 7, 2, 77, 107 };
            int n = 2;
            List<int> expected = new List<int>() { 2, 2 };
            List<int> actual = ArrayFilterDigit.FilterDigit(a, n);
            Assert.AreEqual(expected, actual);
        }
    }
}