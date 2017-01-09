using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
               Console.WriteLine(String.Format("{0}{1}", new String(' ', n-1-i), new String('#', i+1))); 
            }
        }
    }
}
