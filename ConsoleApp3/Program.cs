using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"test.txt";
            WorkFiles.FileTestWrite(path);
            List <string> tests = new List<string>();
            tests = WorkFiles.ReadTests(path);
            int count = 1;
            foreach (string test in tests)
            {
                string[] subs = test.Split(' ');
                double a = double.Parse(subs[0].Trim());
                double b = double.Parse(subs[1].Trim());
                var y = TestFile.calcLinear(a, b);
                Console.WriteLine(y);
                count++;
            }
            Console.WriteLine(TestFile.calcLinear(0.5, 0.5));
            Console.ReadKey();
        }
    }
}
