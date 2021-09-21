using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            var integerCount = arr.Count;

            var countPositive = arr.Count(num => num > 0);
            var countNegative = arr.Count(num => num < 0);
            var countZero = arr.Count(num => num == 0);

            var positiveRatio = (decimal) countPositive / integerCount;
            var negativeRatio = (decimal) countNegative / integerCount;
            var zeroRatio = (decimal) countZero / integerCount;

            Console.WriteLine(positiveRatio.ToString("0.000000"));
            Console.WriteLine(negativeRatio.ToString("0.000000"));
            Console.WriteLine(zeroRatio.ToString("0.000000"));

        }

    }
}
