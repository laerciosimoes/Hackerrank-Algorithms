using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Array_Rotation
{
    class Program
    {

        public static void RotateRight(int[] input, int right)
        {
            for (var i = 0; i < right; i += 1)
            {
                RotateRightOne(input);
            }
        }

        public static void RotateRightOne(int[] input)
        {
            var last = input.Length - 1;
            for (var i = 0; i < last; i += 1)
            {
                input[i] ^= input[last];
                input[last] ^= input[i];
                input[i] ^= input[last];
            }
        }

        static void Main(string[] args)
        {
            var lstQueries = new List<int>();

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                lstQueries.Add(m);
            }

            var b = new int[n];
            int skip;
            if (k == n)
            {
                skip = 0;
            } else if (k < n)
            {
                skip = k;
            }
            else
            {
                skip = k - (n * (k / n));
            }

            var pos = skip;

            for (var i = 0; i < n; i++)
            {
                if (pos == n)
                {
                    pos = 0;
                }
                b[pos] = a[i];
                pos++;
            }

            foreach (var query in lstQueries)
            {
                Console.WriteLine(b[query]);
            }
        }
    }
}
