using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            using (StreamReader reader = new StreamReader("pf1.txt"))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
