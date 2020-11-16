using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            string str = null;
            string path = "C:\\Users\\bptnbs\\Documents\\tada.txt";
            bool fileExists = File.Exists(path);

            if (fileExists)
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

            using(StreamWriter writer = new StreamWriter(path, fileExists))
            {
                Console.Write("Type here to add information to the file: ");

                writer.WriteLine(Console.ReadLine());
            }
        }
    }
}
