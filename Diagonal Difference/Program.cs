using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            var diag1 = 0;
            var diag2 = 0;
            var pos = 0;
            for (int i = 0; i < n; i++)
            {
                diag1 += a[i][pos];
                pos++;
            }
            pos = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                diag2 += a[i][pos];
                pos++;
            }
            Console.WriteLine(Math.Abs(diag1 - diag2));
        }
    }
}
