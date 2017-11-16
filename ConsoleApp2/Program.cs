using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

namespace ConsoleAppTest
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathOperation.Plus(5, 6));
            Console.WriteLine(MathOperation.Plus(5.999999F, 5.999999F));
            int valueInt1 = 1;
            int valueInt2 = 2;
            float valueFloat1 = 1.00001F;
            float valueFloat2 = 2.00002F;
            double valueDouble1 = 1.00;
            double valueDouble2 = 2.00F;
            int[] valueArrayInt1 = { 1, 2, 3, 4, 5, 6, 2, 3, 4 };
            int[] valueArrayInt2 = { 5, 6, 7, 8, 9, 5, 1, 7, 8, 1 };
            float[] valueArrayFloat1 = { 1.2F, 2.5F, 3.3F, 4, 5, 6, 2, 3, 4 };
            float[] valueArrayFloat2 = { 5, 6, 7, 8.1F, 9.0F, 5, 0.423F, 7, 8, 1 };
            double[] valueArrayDouble1 = { 1.2, 2.5, 3.3, 4, 5, 6, 2, 3, 4 };
            double[] valueArrayDouble2 = { 5, 6, 7, 8.1, 9.0, 5, 0.32, 7, 8, 1 };

            int[] resultArrayIntPlus = MathOperation.Plus(valueArrayInt1, valueArrayInt2);
            float[] resultArrayFloatPlus = MathOperation.Plus(valueArrayFloat1, valueArrayFloat2);
            double[] resultArrayDoublePlus = MathOperation.Plus(valueArrayDouble1, valueArrayDouble2);

            int[] resultArrayIntMinus = MathOperation.Minus(valueArrayInt1, valueArrayInt2);
            float[] resultArrayFloatMinus = MathOperation.Minus(valueArrayFloat1, valueArrayFloat2);
            double[] resultArrayDoubleMinus = MathOperation.Minus(valueArrayDouble1, valueArrayDouble2);

            int[] resultArrayIntDivide = MathOperation.Divide(valueArrayInt1, valueArrayInt2);
            float[] resultArrayFloatDivide = MathOperation.Divide(valueArrayFloat1, valueArrayFloat2);
            double[] resultArrayDoubleDivide = MathOperation.Divide(valueArrayDouble1, valueArrayDouble2);

            int[] resultArrayIntMultiply = MathOperation.Multiply(valueArrayInt1, valueArrayInt2);
            float[] resultArrayFloatMultiply = MathOperation.Multiply(valueArrayFloat1, valueArrayFloat2);
            double[] resultArrayDoubleMultiply = MathOperation.Multiply(valueArrayDouble1, valueArrayDouble2);

            int[] resultArrayIntMedian = MathOperation.Median(valueArrayInt1, valueArrayInt2);
            float[] resultArrayFloatMedian = MathOperation.Median(valueArrayFloat1, valueArrayFloat2);
            double[] resultArrayDoubleMedian = MathOperation.Median(valueArrayDouble1, valueArrayDouble2);


            Console.Write("\nPlus:"); Console.Write(MathOperation.Plus(valueInt1, valueInt2));
            Console.Write("\nPlus:"); Console.Write(MathOperation.Plus(valueFloat1, valueFloat2));
            Console.Write("\nPlus:"); Console.Write(MathOperation.Plus(valueDouble1, valueDouble2));
            Console.Write("\nMinus:"); Console.Write(MathOperation.Minus(valueInt1, valueInt2));
            Console.Write("\nMinus:"); Console.Write(MathOperation.Minus(valueFloat1, valueFloat2));
            Console.Write("\nMinus:"); Console.Write(MathOperation.Minus(valueDouble1, valueDouble2));
            Console.Write("\nDivide:"); Console.Write(MathOperation.Divide(valueInt1, valueInt2));
            Console.Write("\nDivide:"); Console.Write(MathOperation.Divide(valueFloat1, valueFloat2));
            Console.Write("\nDivide:"); Console.Write(MathOperation.Divide(valueDouble1, valueDouble2));
            Console.Write("\nMultiply:"); Console.Write(MathOperation.Multiply(valueInt1, valueInt2));
            Console.Write("\nMultiply:"); Console.Write(MathOperation.Multiply(valueFloat1, valueFloat2));
            Console.Write("\nMultiply:"); Console.Write(MathOperation.Multiply(valueDouble1, valueDouble2));        
            Console.Write("\nPlus Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayIntPlus[i] + " ");
            Console.Write("\nPlus Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayFloatPlus[i] + " ");
            Console.Write("\nPlus Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayDoublePlus[i] + " ");
            Console.Write("\nMinus Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayIntMinus[i] + " ");
            Console.Write("\nMinus Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayFloatMinus + " ");
            Console.Write("\nMinus Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayDoubleMinus + " ");
            Console.Write("\nDivide Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayIntDivide + " ");
            Console.Write("\nDivide Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayFloatDivide + " ");
            Console.Write("\nDivide Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayDoubleDivide + " ");
            Console.Write("\nMultiply Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayIntMultiply + " ");
            Console.Write("\nMultiply Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayFloatMultiply + " ");
            Console.Write("\nMultiply Array:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(resultArrayDoubleMultiply + " ");

            Console.Write("\nMax:"); Console.Write(MathOperation.Max(valueInt1, valueInt2));
            Console.Write("\nMax:"); Console.Write(MathOperation.Max(valueFloat1, valueFloat2));
            Console.Write("\nMax:"); Console.Write(MathOperation.Max(valueDouble1, valueDouble2));
            Console.Write("\nMin:"); Console.Write(MathOperation.Min(valueInt1, valueInt2));
            Console.Write("\nMin:"); Console.Write(MathOperation.Min(valueFloat1, valueFloat2));
            Console.Write("\nMin:"); Console.Write(MathOperation.Min(valueDouble1, valueDouble2));
            Console.Write("\nArray of Max:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(MathOperation.Max(valueArrayInt1[i], valueArrayInt2[i]) + " ");
            Console.Write("\nArray of Max:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(MathOperation.Max(valueArrayFloat1[i], valueArrayFloat2[i]) + " ");
            Console.Write("\nArray of Max:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(MathOperation.Max(valueArrayDouble1[i], valueArrayDouble2[i]) + " ");
            Console.Write("\nArray of Min:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(MathOperation.Min(valueArrayInt1[i], valueArrayInt2[i]) + " ");
            Console.Write("\nArray of Min:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(MathOperation.Min(valueArrayFloat1[i], valueArrayFloat2[i]) + " ");
            Console.Write("\nArray of Min:"); for (int i = 0; i < valueArrayInt1.Length; i++) Console.Write(MathOperation.Min(valueArrayDouble1[i], valueArrayDouble2[i]) + " ");

            Console.Write("\nMedian of two numbers:"); Console.Write(MathOperation.Median(valueInt1, valueInt2));
            Console.Write("\nMedian of two numbers:"); Console.Write(MathOperation.Median(valueFloat1, valueFloat2));
            Console.Write("\nMedian of two numbers:"); Console.Write(MathOperation.Median(valueDouble1, valueDouble2));
            Console.Write("\nMedian of an Array:"); Console.Write(MathOperation.Median(valueArrayInt1));
            Console.Write("\nMedian of an Array:"); Console.Write(MathOperation.Median(valueArrayFloat1));
            Console.Write("\nMedian of an Array:"); Console.Write(MathOperation.Median(valueArrayDouble1));
            Console.Write("\nMedian of two Arrays:"); Console.Write(resultArrayIntMedian[0] + " " + resultArrayIntMedian[1]);
            Console.Write("\nMedian of two Arrays:"); Console.Write(resultArrayFloatMedian[0] + " " + resultArrayFloatMedian[1]);
            Console.Write("\nMedian of two Arrays:"); Console.Write(resultArrayDoubleMedian[0] + " " + resultArrayDoubleMedian[1]);


            Console.ReadKey(true);


        }
    }
}
