using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            Console.WriteLine("try and guess my number out of 1 to 10");
            int guess = int.Parse(Console.ReadLine());
            if (guess == number)
                Console.WriteLine("you got it, congrats");
            else if (guess > number)
                Console.WriteLine("sorry was to high a guess");
            else
                Console.WriteLine("sorry was to low a guess");

            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
