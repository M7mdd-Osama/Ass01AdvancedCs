using System;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ///The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases,
            ///which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm
            ///And implement the code of this optimized bubble sort algorithm

            //int[] Numbers = { 3, 0, 5, 4, 2, 4, 6, 8, 7, 6, 1 };

            //Helper.BubbleSort(Numbers);

            //foreach (int i in Numbers)
            //{
            //    Console.Write($"{i} " );
            //} 
            #endregion

            #region Q2
            ///create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
            ///The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            ///Requirements:
            ///1. Create a generic class named Range<T> where T represents the type of values.
            ///2. Implement a constructor that takes the minimum and maximum values to define the range.
            ///3. Implement a method IsInRange(T value) that returns true if the given value is within the range, otherwise false.
            ///4. Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            ///5. Note: You can assume that the type T used in the Range<T> class implements the IComparable < T > interface to allow for comparisons.
            
            //Range<int> intRange = new Range<int>(5, 10);
            //Console.WriteLine(intRange.IsInRange(7));
            //Console.WriteLine(intRange.Length());

            //Range<double> doubleRange = new Range<double>(1.2, 3.5);
            //Console.WriteLine(doubleRange.IsInRange(4.5));
            //Console.WriteLine(doubleRange.Length());
            #endregion
        }
    }
}
