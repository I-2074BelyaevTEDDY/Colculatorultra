using System;

namespace Calcylatorultra
{
    public class GUIConsoleApp
    {
        public double Sum(int[] array)
        {
            double s = 0;
            foreach (var x in array) s += x;
            return s;
        }

        public int Count(int[] array) { return array.Length; }

        public int Max(int[] array)
        {
            int max = array[0];
            foreach (var x in array) if (x > max) max = x;
            return max;
        }

        public int Min(int[] array)
        {
            int min = array[0];
            foreach (var x in array) if (x < min) min = x;
            return min;
        }

        public int FindIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i+=1)
            {
                if (array[i] == target) return i;
            }
            return -1;
        }


        public int[] Sort(int[] array)
        {
            int[] sorted = (int[])array.Clone();
            for (int i = 0; i < sorted.Length - 1; i+=1)
            {
                for (int j = 0; j < sorted.Length - i - 1; j+=1)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        int temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }
    }
}
