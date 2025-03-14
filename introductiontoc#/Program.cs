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
            // This code would output "The multiplied ID is 1000"


            //Math methods
            double p = -80;
            double absValue = Math.Abs(p); // 80
            double sqRoot = Math.Sqrt(absValue); // 8.94427190999916
            double floored = Math.Floor(sqRoot); // 8
            double smaller = Math.Min(p, sqRoot); // -80


            // operator shortcuts
            int d = 0;
            d++; // 1
            d--; // 0
            d += 5; // 5
            d -= 5; // 0    
            d *= 5; // 0
            d /= 5; // 0
            d %= 5; // 0

            //String
            string str1 = "This is C# Program xsdd_$#%";
            string upperStr1 = str1.ToUpper(); // THIS IS C# PROGRAM XSDD_$#%
            string lowerStr1 = str1.ToLower(); // this is c# program xsdd_$#%
            string str2 = "Divyesh";
            int index1 = str1.IndexOf("C#"); // 8
            Console.WriteLine("The index Value of character 's' is " + index1); // The Index Value of character 's' is 5

            //accessing values in a string
            string value = "Dot Net Perls";
            char first = value[0]; // 'D'
            char second = value[1]; // 'o'
            char last = value[value.Length - 1]; // 's'

            // string substrings
            string myStr = "Divyesh";
            string test1 = myStr.Substring(2);

            // string concatenation
            string firstName = "Divyesh";
            string lastName = "Wase";
            string fullName = firstName + " " + lastName; // Divyesh Wase
            Console.WriteLine(fullName);

            // get the length of the string
            string myString = "Dot Net Perls";
            Console.WriteLine(myString.Length); // 13

            string[] characters =  { "Huey", "Dewey", "Louie" };
            Console.WriteLine(string.Join(", ",characters)); 

            //converting data types 
            double positiveDouble = 5.5;
            int positiveInt = (int)positiveDouble; // 5
            Console.WriteLine(positiveInt);
        }
    }
}
