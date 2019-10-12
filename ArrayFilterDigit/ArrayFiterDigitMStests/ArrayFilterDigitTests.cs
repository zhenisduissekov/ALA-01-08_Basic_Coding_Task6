// Copyright (c) EPAM
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace ArrayFiterDigitNStests
{
    using ArrayFilterDigitNS;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class ArrayFilterDigitTests
    {
        [TestMethod]

        /// <summary>
        /// Our first test: returning all elements that inclue digit 7
        /// </summary>
        public void FilterDigit1_2_3_4_5_7_2_77_107returned_7_77_107()
        {
            // arrange
            int[] a = { 1, 2, 3, 4, 5, 7, 2, 77, 107 };
            int n = 7;
            List<int> expected = new List<int>() { 7, 77, 107 };

            // act
            List<int> actual = ArrayFilterDigit.FilterDigit(a, n);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]

        /// <summary>
        /// Our first test: 1 element found includes 0
        /// </summary>
        public void FilterDigit1_2_3_4_5_7_2_77_107returned_0()
        {
            // arrange
            int[] a = { 1, 2, 3, 4, 5, 7, 2, 77, 107 };
            int n = 0;
            List<int> expected = new List<int>() { 107 };

            // act
            List<int> actual = ArrayFilterDigit.FilterDigit(a, n);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
