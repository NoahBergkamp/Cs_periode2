using System;
using System.IO;

namespace fileToevoegen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Program program = new Program();
        program.run();
    }

    private void run()
    {
            Console.WriteLine(Environment.CurrentDirectory);

            string[] lines = File.ReadAllLines("quiz.txt");

            for ( int i = 0; i < lines.Length ; i++)
            {
                Console.WriteLine(lines[i]);
            }
           string[]articalLines = File.ReadAllLines("nos.txt");
            for ( int i = 0; i < articalLines.Length ; i++)
            {
                Console.WriteLine(articalLines[i]);
            }

    }
}
