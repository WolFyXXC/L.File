using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class WorkFiles
    {
        static Random rnd = new Random();
        public static void FileTestWrite(string path)
        {
            try
            {
                using (StreamWriter st = new StreamWriter(path))
                    for (int i = 0; i < 10; i++)
                        st.WriteLine($"{rnd.NextDouble() * 2} {rnd.NextDouble() * 2}");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        public static List<string> ReadTests(string path)
        {
            List<string> tests = new List<string>();
            string line = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                    while ((line = sr.ReadLine()) != null)
                        tests.Add(line);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            return tests;
        }
    }
}
