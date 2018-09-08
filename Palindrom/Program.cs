using System;

namespace Palindrom
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type word to verify or [q] to exit");
                var word = Console.ReadLine();
                if (word == "q")
                    break;
                else
                {
                    var result = PalindromChecker.IsPalindrom(word);
                    Console.WriteLine($" Word [{word}] {(result ? "is" : "is not" )} a palindrom");
                }
            }          
        }
    }
}
