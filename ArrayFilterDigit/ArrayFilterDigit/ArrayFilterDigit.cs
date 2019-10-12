// Copyright (c) EPAM
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace ArrayFilterDigitNS
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Our class
    /// </summary>
    public class ArrayFilterDigit
    {
        /// <summary>
        /// Our method that needed to be done
        /// </summary>
        public static List<int> FilterDigit(int[] a, int n)
        {
            // creating a list of integers
            List<int> valid_str = new List<int>();

            // converting number to string
            string str_n = Convert.ToString(n);

            // creating an empty string
            string str_a_i;

            // loop through elements in array
            for (int i = 0; i < a.Length; i++)
            {
                // convert into string in order to search
                str_a_i = Convert.ToString(a[i]);

                // if number is among digits then index will show its placement
                if (str_a_i.IndexOf(str_n, StringComparison.Ordinal) != -1)
                {
                    // add the element into a new list
                    valid_str.Add(a[i]);
                }
            }

            return valid_str; // return our new list
        }

        /// <summary>
        /// Our Main
        /// </summary>
        public static void Main()
        {
            int[] a = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int n = 7;
            foreach (var element in FilterDigit(a, n))
            {
                Console.Write(element + ", ");
            }
        }
    }
}
