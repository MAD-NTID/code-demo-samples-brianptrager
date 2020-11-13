using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string path = "pf2.txt";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
