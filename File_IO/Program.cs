using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO implementation");
            // check whether the file exists or not 

            string path = "E:\\Sushil\\.net Projects\\File_IO\\File_IO\\Demo.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File does not exists");

            //ReadAllText in file >>> reads all lines at once and stores in th string variable
            Console.WriteLine("Printing by readAllText method");
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            //ReadAllLines(path) >>> reads line by line and stores in th string array variable
            Console.WriteLine("Printing by readAllLines method");
            string[] filelines = File.ReadAllLines(path);
            foreach (string line in filelines)
            {
                Console.WriteLine(line);
            }
        }
    }
}