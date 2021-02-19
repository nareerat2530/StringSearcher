using System;

namespace Iths_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string ");
            var input = Console.ReadLine();
            Console.WriteLine();
            
            long total = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var length = 1;

                for (var j = i + 1; j < input.Length; j++)
                {
                    if (!int.TryParse(input[j].ToString(), out var num)) break;

                    length++;

                    if (input[i] != input[j]) continue;
                    var substring = input.Substring(i, length);
                    var substring2 = input.Substring(j+1);
                    Console.Write(input.Substring(0, i));
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(substring);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(substring2);
                    Console.WriteLine();
                    total += long.Parse(substring);
                    break;

                }
            } 
            Console.WriteLine($"\nTotal sum is {total} ");
        }
    }
}
