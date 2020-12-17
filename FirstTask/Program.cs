using System;

namespace CSharpExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text");
            var text = Console.ReadLine();
            Console.WriteLine(text.Substring(0, 1) + text + text.Substring(0, 1) );
            
        }
    }
}