using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class TestFile
    {
        public static double? calcLinear(double a, double x)
        {
            double y = Math.Sqrt(Math.Abs(x - a)) / (x - a)
            + Math.Sqrt(Math.Abs(x + a)) / (x + a);

            try
            {
                if (double.IsNaN(y))
                {
                    throw new InfinityException("Результат не является числом");
                }
                if (double.IsPositiveInfinity(y))
                {
                    throw new InfinityException("Результат не является числом");
                }
            }
            catch (Exception ex)  
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return
        }
    }
}
