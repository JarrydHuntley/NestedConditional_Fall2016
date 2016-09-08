using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedConditional_Fall2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Please enter your age.");

            age = int.Parse(Console.ReadLine());

            if (age >= 16)
            {
                Console.WriteLine("You can drive. >:(");

                if (age >= 18)
                {
                    Console.WriteLine("You're an adult?");
                }
                else
                {
                    Console.WriteLine("You're not an adult yet.");
                }
            }



        }
    }
}
