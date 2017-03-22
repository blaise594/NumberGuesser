using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = new Random().Next(1, 101);
            Console.WriteLine($"the target is {target}");

            var counter = 0;
            var guess = 0;
            while (counter < 5 && guess != target)
            { 
                Console.WriteLine($"Guess now");    
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                Console.WriteLine("You guessed {guess}");
                
                if (guess < target)
                {
                    Console.WriteLine("Your guess was too low");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Your guess was too high");
                }
                counter++;
            }
            
            if()
        }
        
    }

}
