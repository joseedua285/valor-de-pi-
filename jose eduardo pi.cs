using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloPiApproximation
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 1000000;
            int insideCircle = 0;
            Random random = new Random();

            for (int i = 0; i < totalPoints; i++)
            {
                double x = random.NextDouble() * 2 - 1;
                double y = random.NextDouble() * 2 - 1; 

                double distance = Math.Sqrt(x * x + y * y);

                if (distance <= 1)
                {
                    insideCircle++;
                }
            }

           
            double piApproximation = 4.0 * insideCircle / totalPoints;

         
            Console.WriteLine("Valor aproximado de π: " + piApproximation);
            Console.ReadLine();
        }
    }
}
//jose eduardo lopez perez