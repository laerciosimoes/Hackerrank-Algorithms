using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            var aTime = time.Split(':');
            var hour = Convert.ToInt32(aTime[0]);
            var minute = Convert.ToInt32(aTime[1]);
            var second = Convert.ToInt32(aTime[2].Substring(0, 2));
            var ampm = aTime[2].Substring(2, 2);
            if (ampm == "PM")
            {
                if (hour < 12)
                {
                    hour += 12;
                }
            }
            else
            {
                if (hour == 12) hour = 0;
            }
            Console.WriteLine(String.Format("{0}:{1}:{2}",
                                            hour.ToString("00"),
                                            minute.ToString("00"),
                                            second.ToString("00")));
        }
    }
}
