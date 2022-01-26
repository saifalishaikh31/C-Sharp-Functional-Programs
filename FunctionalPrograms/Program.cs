using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1.Two Dimensional Array."
                    + "\n 2.Sum of three integers"
                    + "\n 3.Distance x and y"
                    + "\n 4.Quadratic Roots"
                    + "\n 5.Wind Chill"
                    + "\n 6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: TwoDArray twodimarray = new TwoDArray();
                        twodimarray.TwoDimArray();
                        break;
                    case 2:
                        SumOfThreeAddsZero sumofthreeaddszero = new SumOfThreeAddsZero();
                        sumofthreeaddszero.FindTriplets();
                        flag = false;
                        break;
                    case 3:
                        Distance distance = new Distance();
                        distance.FindDistance();
                        break;
                    case 4:
                        Quadratic qaudratic = new Quadratic();
                        qaudratic.FindQuadratic();
                        break;
                    case 5:
                        WindChill wchill = new WindChill();
                        wchill.Weather();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default: Console.WriteLine("Choose Correct option");
                        break; 
                       
                }
            } Console.ReadLine(); 
           
        }
    }
}
