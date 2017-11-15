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
            Console.WriteLine(MathOperation.Plus(5,6));
            Console.WriteLine(MathOperation.Plus(5.999999F, 5.999999F));

            float valFloat1 = 1.01;
            float valFloat2 = 2.02;
            float[] val1 = {1.2F,2.5F,3.3F,4,5,6,2,3,4};
            float[] val2 = {5,6,7,8.1F,9.0F,5,0,7,8,1,2,3,4,5,1,2,-3};
            float[] val3 = MathOperation.Plus(val1,val2);
            float[] val4 = MathOperation.Minus(val1, val2);
            float[] val5 = MathOperation.Divide(val1, val2);
            float[] val6 = MathOperation.Multiply(val1, val2);
            float[] val7 = MathOperation.Max(val1, val2);
            float[] val8 = MathOperation.Min(val1, val2);           
            float val10 = MathOperation.Median(val1);
            float[] val11 = MathOperation.Median(val1, val2);

            double val14 = MathOperation.Plus(1.33, 1.22);

            Console.WriteLine("\nPlus:"); Console.WriteLine(val14);


            Console.WriteLine("\nPlus:"); for (int i = 0; i < val3.Length; i++) Console.Write(val3[i] + " ");

            Console.WriteLine("\nMinus:"); for (int i = 0; i < val3.Length; i++) Console.Write(val4[i] + " ");

            Console.WriteLine("\nDivide:");
            for (int i = 0; i < val3.Length; i++)
            {
                Console.Write(val5[i] + " ");
            }
            Console.WriteLine("\nMultiply:");
            for (int i = 0; i < val3.Length; i++)
            {            
                Console.Write(val6[i] + " ");
            }
            Console.WriteLine("\nMax: ");
            for (int i = 0; i < val7.Length; i++)
            {
                Console.Write(val7[i] + " ");
            }
            Console.WriteLine("\nMin: ");
            for (int i = 0; i < val8.Length; i++)
            {
                Console.Write(val8[i] + " ");
            }
            Console.WriteLine("\nMedian 2 arrays: ");            
            for (int i = 0; i < 2; i++)
            {
                Console.Write(val11[i] + " ");
            }

            Console.ReadKey(true);

            
        }
    }
}
