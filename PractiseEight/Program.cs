using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseEight
{
    class Program
    {
        static void Main(string[] args)

        {

            int Min = 0;
            int Max = 10;

            int[] RandomArray = new int[5];

            int[] ArrayInts = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < ArrayInts.Length; i++)
            {
                ArrayInts[i] = randNum.Next(Min, Max);
                Console.WriteLine(ArrayInts[i]);
            }
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
