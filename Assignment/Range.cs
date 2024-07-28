﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
            if (min.CompareTo(max) > 0)
                Console.WriteLine("Min value should be less than or equal to Max value.");
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            double min = Convert.ToDouble(Min);
            double max = Convert.ToDouble(Max);
            return max - min;
        }
        public override string ToString()
        {
            return $"Min = {Min} , Max = {Max}";
        }

    }
}
