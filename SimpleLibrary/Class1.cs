using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public class MathOperation
    {
        // Plus

        public static int Plus(int value1, int value2)
        {
            return value1 + value2;
        }

        public static float Plus(float value1, float value2) 
        {
            return value1 + value2;
        }

        public static double Plus(double value1, double value2)
        {
            return value1 + value2;
        }

        public static int[] Plus(int[] value1, int[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            int[] resultArray = new int[length];
            for (int i = 0; i < length ; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] + value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;           
        }

        public static float[] Plus(float[] value1, float[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            float[] resultArray = new float[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] + value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        public static double[] Plus(double[] value1, double[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            double[] resultArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] + value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        // Minus

        public static int Minus(int value1, int value2)
        {
            return value1 - value2;
        }

        public static float Minus(float value1, float value2)
        {
            return value1 - value2;
        }

        public static double Minus(double value1, double value2)
        {
            return value1 - value2;
        }

        public static int[] Minus(int[] value1, int[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] - value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = 0 - value2[i];
            }
            return resultArray;

        }

        public static float[] Minus(float[] value1, float[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            float[] resultArray = new float[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] - value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = 0 - value2[i];
            }
            return resultArray;
        }

        public static double[] Minus(double[] value1, double[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            double[] resultArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] - value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = 0 - value2[i];
            }
            return resultArray;
        }

        // Divide

        public static int Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        public static float Divide(float value1, float value2)
        {
            return value1 / value2;
        }

        public static double Divide(double value1, double value2)
        {
            return value1 / value2;
        }

        public static int[] Divide(int[] value1, int[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] / value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = 1 / value2[i];
            }
            return resultArray;

        }

        public static float[] Divide(float[] value1, float[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            float[] resultArray = new float[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] / value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = 1 / value2[i];
            }
            return resultArray;
        }

        public static double[] Divide(double[] value1, double[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            double[] resultArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] / value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = 1 / value2[i];
            }
            return resultArray;
        }

        // Multiply

        public static int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public static float Multiply(float value1, float value2)
        {
            return value1 * value2;
        }

        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public static int[] Multiply(int[] value1, int[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] * value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;

        }

        public static float[] Multiply(float[] value1, float[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            float[] resultArray = new float[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] * value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        public static double[] Multiply(double[] value1, double[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            double[] resultArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = value1[i] * value2[i];

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        // Minumum

        public static int Min(int value1, int value2)
        {
            if (value1> value2) return value2;
            else return value1;
        }

        public static float Min(float value1, float value2)
        {
            if (value1 > value2) return value2;
            else return value1;
        }

        public static double Min(double value1, double value2)
        {
            if (value1 > value2) return value2;
            else return value1;
        }

        public static int[] Min(int[] value1, int[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = Min(value1[i], value2[i]);

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;

        }

        public static float[] Min(float[] value1, float[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            float[] resultArray = new float[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = Min(value1[i], value2[i]);

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        public static double[] Min(double[] value1, double[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            double[] resultArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = Min(value1[i], value2[i]);

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        // Maximum

        public static int Max(int value1, int value2)
        {
            if (value1 > value2) return value1;
            else return value2;
        }

        public static float Max(float value1, float value2)
        {
            if (value1 > value2) return value1;
            else return value2;
        }

        public static double Max(double value1, double value2)
        {
            if (value1 > value2) return value1;
            else return value2;
        }

        public static int[] Max(int[] value1, int[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = Max(value1[i], value2[i]);

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;

        }

        public static float[] Max(float[] value1, float[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            float[] resultArray = new float[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = Max(value1[i], value2[i]);

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        public static double[] Max(double[] value1, double[] value2)
        {
            int length = MathOperation.Max(value1.Length, value2.Length);
            double[] resultArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                if (i < Min(value1.Length, value2.Length)) resultArray[i] = Max(value1[i], value2[i]);

                else if (value1.Length > value2.Length) resultArray[i] = value1[i];

                else resultArray[i] = value2[i];
            }
            return resultArray;
        }

        // Median

        public static int Median(int value1, int value2)
        {
            return (value1 + value2)/2;
        }

        public static float Median(float value1, float value2)
        {
            return (value1 + value2) / 2;
        }

        public static int Median(int[] value1)
        {        
            if (value1 == null || value1.Length == 0)
                throw new System.Exception("Median of empty array not defined.");
            //make sure the list is sorted, but use a new array
            int[] sortedNumbers = (int[])value1.Clone();
            Array.Sort(sortedNumbers);
            //get the median
            int size = sortedNumbers.Length;
            int mid = size / 2;
            int median = (size % 2 != 0) ? (int)sortedNumbers[mid] : ((int)sortedNumbers[mid] + (int)sortedNumbers[mid - 1]) / 2;
            return median;
        }

        public static float Median(float[] value1)
        {      
            if (value1 == null || value1.Length == 0)
                throw new System.Exception("Median of empty array not defined.");
            float[] sortedNumbers = (float[])value1.Clone();
            Array.Sort(sortedNumbers);
            int size = sortedNumbers.Length;
            int mid = size / 2;
            float median = (size % 2 != 0) ? (float)sortedNumbers[mid] : ((float)sortedNumbers[mid] + (float)sortedNumbers[mid - 1]) / 2;
            return median;
        }

        public static double Median(double[] value1)
        {            
            if (value1 == null || value1.Length == 0)
                throw new System.Exception("Median of empty array not defined.");
            double[] sortedNumbers = (double[])value1.Clone();
            Array.Sort(sortedNumbers);
            int size = sortedNumbers.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sortedNumbers[mid] : ((double)sortedNumbers[mid] + (double)sortedNumbers[mid - 1]) / 2;
            return median;
        }

        public static int[] Median(int[] value1, int[] value2)
        {
            if (value1 == null || value1.Length == 0 || value2 == null || value2.Length == 0)
                throw new System.Exception("Median of empty array not defined.");
            int[] sortedNumbers1 = (int[])value1.Clone(); Array.Sort(sortedNumbers1);
            int[] sortedNumbers2 = (int[])value2.Clone(); Array.Sort(sortedNumbers2);
            int size1 = sortedNumbers1.Length;
            int size2 = sortedNumbers2.Length;
            int mid1 = size1 / 2;
            int mid2 = size2 / 2;
            int[] median = new int[2];
            median[0] = (size1 % 2 != 0) ? (int)sortedNumbers1[mid1] : ((int)sortedNumbers1[mid1] + (int)sortedNumbers1[mid1 - 1]) / 2;
            median[1] = (size2 % 2 != 0) ? (int)sortedNumbers2[mid2] : ((int)sortedNumbers2[mid2] + (int)sortedNumbers2[mid2 - 1]) / 2;
            return median;
        }

        public static float[] Median(float[] value1, float[] value2)
        {     
            if (value1 == null || value1.Length == 0 || value2 == null || value2.Length == 0)
                throw new System.Exception("Median of empty array not defined.");
            float[] sortedNumbers1 = (float[])value1.Clone(); Array.Sort(sortedNumbers1);
            float[] sortedNumbers2 = (float[])value2.Clone(); Array.Sort(sortedNumbers2);
            int size1 = sortedNumbers1.Length;
            int size2 = sortedNumbers2.Length;
            int mid1 = size1 / 2;
            int mid2 = size2 / 2;
            float[] median = new float[2];
            median[0] = (size1 % 2 != 0) ? (int)sortedNumbers1[mid1] : ((int)sortedNumbers1[mid1] + (int)sortedNumbers1[mid1 - 1]) / 2;
            median[1] = (size2 % 2 != 0) ? (int)sortedNumbers2[mid2] : ((int)sortedNumbers2[mid2] + (int)sortedNumbers2[mid2 - 1]) / 2;
            return median;
        }

        public static double[] Median(double[] value1, double[] value2)
        {      
            if (value1 == null || value1.Length == 0 || value2 == null || value2.Length == 0)
                throw new System.Exception("Median of empty array not defined.");
            double[] sortedNumbers1 = (double[])value1.Clone(); Array.Sort(sortedNumbers1);
            double[] sortedNumbers2 = (double[])value2.Clone(); Array.Sort(sortedNumbers2);
            int size1 = sortedNumbers1.Length;
            int size2 = sortedNumbers2.Length;
            int mid1 = size1 / 2;
            int mid2 = size2 / 2;
            double[] median = new double[2];
            median[0] = (size1 % 2 != 0) ? (int)sortedNumbers1[mid1] : ((int)sortedNumbers1[mid1] + (int)sortedNumbers1[mid1 - 1]) / 2;
            median[1] = (size2 % 2 != 0) ? (int)sortedNumbers2[mid2] : ((int)sortedNumbers2[mid2] + (int)sortedNumbers2[mid2 - 1]) / 2;
            return median;
        }

    }
}
