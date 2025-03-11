using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductiontoc_
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Rebecca Wase");

            //getting input from the user
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} year old!");  //output the input

            // variables
            string foo = "Hello";
            string bar = "How are you doing?";
            int x = 5;
            Console.WriteLine(foo);


            //single line comment
            /*
             multi line comment
             */

            // Arithmetic operators
            int result;
            result = 5 + 5; // 10
            result = 5 - 5; // 0
            result = 5 * 5; // 25
            result = 5 / 5; // 1
            result = 5 % 2; // 1

            Console.WriteLine(result);

            // string interpolation
            int id = 100;
            // We can use an expression with a string interpolation.
            string multipliedNumber = $"The multiplied ID is {id * 10}.";
            Console.WriteLine(multipliedNumber);

        }
    }
}
