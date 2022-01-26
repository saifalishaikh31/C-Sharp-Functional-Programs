using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
        public void FindDistance()
        {
            Console.WriteLine("Enter x distance");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y distance");
            int y = Convert.ToInt32(Console.ReadLine());
            double cal_distance = Math.Sqrt(x*x + y*y);
            Console.WriteLine("distance from (" + x + ", " + y + ") to (0, 0) = " + cal_distance);
        }
    }
}
