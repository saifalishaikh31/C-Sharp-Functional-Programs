using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public void Weather()
        {
            Console.WriteLine("Enter temperature (in fahrenheit):");
            double t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Wind Speed (in miles per hour)");
            double v = Convert.ToInt32(Console.ReadLine());
            if (t < 50 && v > 3 && v < 120)
            {
                double windchill = (35.74 + 0.6215 * t + 0.4275 * t - 35.75) * Math.Pow(v, 0.16);
                Console.WriteLine("The WindChill is: " + windchill);
            }

            else
            {
                Console.WriteLine("Temperature or Speed is not valid!!!");
                Console.WriteLine("Enter Temperature less than 50 and Speed less than 120 and greater than 3");
                
            }
        }
    }
}
