using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalPrograms
{
    class Quadratic
    {
        double a, b, c, delta, root1, root2;
        public void FindQuadratic()
        {

            Console.WriteLine("Input value for a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value for b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value for c : ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = (b * b - 4 * a * c);
            double sqrtdelta = Math.Sqrt(delta);
            root1 = (-b + sqrtdelta) / 2 * a;
            root2 = (-b - sqrtdelta) / 2 * a;
            Console.WriteLine("Root 1 of x :" + (double)root1);
            Console.WriteLine("Root 2 of x :" + (double)root2);
        }
    }
}
    
