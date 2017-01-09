using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            double positive = 0;
            double negative = 0;
            double zeros = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    positive++;
                } else if (num < 0)
                {
                    negative++;
                }
                else
                {
                    zeros++;
                }
            }
            Console.WriteLine(Math.Round(positive / arr.Length, 5));
            Console.WriteLine(Math.Round(negative/ arr.Length, 5));
            Console.WriteLine(Math.Round(zeros / arr.Length, 5));
        }
    }
}
