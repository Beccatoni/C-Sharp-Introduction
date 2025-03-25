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
            Numbers();
            //Console.WriteLine("Rebecca Wase");

            //  //getting input from the user
            //  Console.WriteLine("How old are you?");
            //  string input = Console.ReadLine();
            //  Console.WriteLine($"You are {input} year old!");  //output the input

            //  // variables
            //  string foo = "Hello";
            //  string bar = "How are you doing?";
            //  int x = 5;
            //  Console.WriteLine(foo);


            //  //single line comment
            //  /*
            //   multi line comment
            //   */

            //  // Arithmetic operators
            //  int result;
            //  result = 5 + 5; // 10
            //  result = 5 - 5; // 0
            //  result = 5 * 5; // 25
            //  result = 5 / 5; // 1
            //  result = 5 % 2; // 1

            //  Console.WriteLine(result);

            //  // string interpolation
            //  int id = 100;
            //  // We can use an expression with a string interpolation.
            //  string multipliedNumber = $"The multiplied ID is {id * 10}.";
            //  Console.WriteLine(multipliedNumber);
            //  // This code would output "The multiplied ID is 1000"


            //  //Math methods
            //  double p = -80;
            //  double absValue = Math.Abs(p); // 80
            //  double sqRoot = Math.Sqrt(absValue); // 8.94427190999916
            //  double floored = Math.Floor(sqRoot); // 8
            //  double smaller = Math.Min(p, sqRoot); // -80


            //  // operator shortcuts
            //  int d = 0;
            //  d++; // 1
            //  d--; // 0
            //  d += 5; // 5
            //  d -= 5; // 0    
            //  d *= 5; // 0
            //  d /= 5; // 0
            //  d %= 5; // 0

            //  //String
            //  string str1 = "This is C# Program xsdd_$#%";
            //  string upperStr1 = str1.ToUpper(); // THIS IS C# PROGRAM XSDD_$#%
            //  string lowerStr1 = str1.ToLower(); // this is c# program xsdd_$#%
            //  string str2 = "Divyesh";
            //  int index1 = str1.IndexOf("C#"); // 8
            //  Console.WriteLine("The index Value of character 's' is " + index1); // The Index Value of character 's' is 5

            //  //accessing values in a string
            //  string value = "Dot Net Perls";
            //  char first = value[0]; // 'D'
            //  char second = value[1]; // 'o'
            //  char last = value[value.Length - 1]; // 's'

            //  // string substrings
            //  string myStr = "Divyesh";
            //  string test1 = myStr.Substring(2);

            //  // string concatenation
            //  string firstName = "Divyesh";
            //  string lastName = "Wase";
            //  string fullName = firstName + " " + lastName; // Divyesh Wase
            //  Console.WriteLine(fullName);

            //  // get the length of the string
            //  string myString = "Dot Net Perls";
            //  Console.WriteLine(myString.Length); // 13

            //  string[] characters =  { "Huey", "Dewey", "Louie" };
            //  Console.WriteLine(string.Join(", ",characters)); 

            //  //converting data types but here data is lost
            //  double positiveDouble = 5.5;
            //  int positiveInt = (int)positiveDouble; // 5
            //  Console.WriteLine(positiveInt);

            //  //string to int
            //  Console.WriteLine("Enter your favorite number");
            //  int favNumber = Convert.ToInt32(Console.ReadLine());

        }

        static void Numbers() {
            // calculate the netIncome in double
            double revenue = 853023.45;
            double expenses = 438374.11;
            double netIncome = revenue - expenses;
            Console.WriteLine(netIncome);

            // Calculate a Break-Even Point;
            double fixedCosts = 912849.30;
            double salesPrice = 29.99;
            double variableCostPerUnit = 17.65;

            double breakEvenVolume = fixedCosts / (salesPrice - variableCostPerUnit);
            Console.WriteLine(breakEvenVolume);


            // declaring different variables with different data types 
            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            decimal revenue2 = 390819.28m;

            // Log the values to the console:
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue2);


            //number values
            // Your Age
            int userAge = 26;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;
            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(userAge);
            Console.WriteLine(jupiterYears);
            Console.WriteLine(jupiterAge);
            Console.WriteLine(journeyToJupiter);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

            //
            // Declare steps variable
            int steps = 0;

            // Two steps forward 
            steps = steps + 2;

            // One step back 
            steps--;

            // Print result to the console
            Console.WriteLine(steps);

            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));


            //working with text
            string drink = "wine";
            string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone.\nAlice looked" +
                $" all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked. \n\"There isn't any," +
                $" \" said the March Hare.";

            int storyLength = madTeaParty.Length;
            string toFind = "March Hare";

            string findLowerCase = toFind.ToLower();
            int findMarchHare = madTeaParty.IndexOf(toFind);

            Console.WriteLine(madTeaParty.Substring(findMarchHare));
            Console.WriteLine($"This scene is {storyLength} long.\n");
            Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}.");
            Console.ReadLine();


            // conditionals
            string color = "blue";

            if (color == "blue")
            {
                // this will execute only if the value of color is equal to "blue"
                Console.WriteLine("color is blue");
            }

            //example two
            double ph = 7;
            if (ph < 7)
            {
                Console.WriteLine("Acidic");
            }
            else if (ph > 7)
            {
                Console.WriteLine("Basic");
            }
            else
            {
                Console.WriteLine("Neutral");
            }


            //switch statement
            int speed = 100;

            switch (speed)
            {
                case < 25:
                    // Executes if the value of speed is less than 25
                    Console.WriteLine("Going slowly");
                    break;
                case 25:
                    // Executes if the value of speed is equal to 25
                    Console.WriteLine("Going at correct speed");
                    break;
                case < 30:
                    // Executes if the value of speed is between 25 and 30
                    Console.WriteLine("Going slightly too fast");
                    break;
                default:
                    // The speed must be over 30 due to the above conditions
                    Console.WriteLine("Going much too fast");
                    break;
            }

            // Would print "Going much too fast"

           


            /*
            if (ph < 7)
            {
              Console.WriteLine("Acidic");
            }
            else if (ph > 7)
            {
              Console.WriteLine("Basic");
            }
            else 
            {
              Console.WriteLine("Neutral");
            }
            */
            switch (ph)
            {
                case <= 3:
                    Console.WriteLine("Very Acidic");
                    break;
                case >= 11:
                    Console.WriteLine("Very Basic");
                    break;
                case < 7:
                    Console.WriteLine("Acidic");
                    break;
                case > 7:
                    Console.WriteLine("Basic");
                    break;
                default:
                    Console.WriteLine("Neutral");
                    break;
            }


            //Arrays
            // Initial declaration
            int[] plantHeights;

            // This will cause an error
            // plantHeights = { 3, 4, 6 }; 

            // This will work
            plantHeights = new int[] { 3, 4, 6 };

            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars");


            //editing arrays
       

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            summerStrut[7] = "Ushaka wese";
            ratings[7] = 5;

            // array built-in methods
            int indexOfthree = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {indexOfthree + 1} is rated three stars");
            Array.Reverse(summerStrut);
            Console.WriteLine($"{summerStrut[0]} {summerStrut[7]}");
            Array.Sort(summerStrut);
            Console.WriteLine($"{summerStrut[0]} {summerStrut[7]}");

            //loops
            int emails = 20;
            while (emails > 0)
            {
                Console.WriteLine("The number emails is decreasing");
                emails--;
            }
            Console.WriteLine("INBOX ZERO ACHIEVED!");

            // do...while loop
            bool buttonClick = true;
            do
            {
                Console.WriteLine("The Alarm is ringing");
            } while (!buttonClick);

            //for loop
           for(int i = 1; i<17; i++)
            {
                CreateTemplate(i);
            }


            // foreach loop
            string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
            foreach (string todoItem in todo)
            {
                Console.WriteLine($"[] {todoItem}");
            }

            string[] websites = { "twitter", "facebook", "gmail" };
            foreach (string website in websites)
            {
                Console.WriteLine(website);
            }


            //jump statements
            int alarmCount = 0;
            do
            {
                Console.WriteLine("BLARRRRR");
                alarmCount++;
                if (alarmCount == 3)
                {
                    break;
                }

            } while (!buttonClick);
            

            //lists 
            List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
            Console.WriteLine(marathons.Count);
            marathons.Add(143.23);
            Console.WriteLine(marathons.Contains(143.23));
            Console.WriteLine(marathons.Count);


            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kyiv" };
            bool success = citiesList.Remove("Delhi");  // success is true

            Console.WriteLine(marathons[1]);
            bool removed = marathons.Remove(143.12);
            Console.WriteLine($"{marathons[1]}, {removed}");
            citiesList.Clear();

            List<double> topMarathons = marathons.GetRange(0, 3);
            foreach (double marathon in topMarathons)
            {
                Console.WriteLine(marathon);
                Console.WriteLine(citiesList.Count);

            // working with ranges
            List<string> places = new List<string> { "first", "second" };
            places.AddRange(new string[] { "fifth", "sixth" });
            places.InsertRange(2, new string[] { "third", "fourth" });
            places.RemoveRange(4, 2);
            List<string> newPlaces = places.GetRange(0, 3);



                // methods 
                // out parameters

                int length = 5;
                int width = 6;

                CalculateRectangle(length, width, out int area, out int perimeter);
                Console.WriteLine($"Area: {area}");//prints "Area: 30"
                Console.WriteLine($"Perimeter: {perimeter}"); // prints "Perimeter: 22"
                
                // Classes and objects
                Forest f = new Forest("Amazon");
                Console.WriteLine(f.name);
                
                Console.ReadLine();

        }
        static void CreateTemplate(int week)
        {

            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");

        }

        static void CalculateRectangle(int length, int width, out int area, out int perimeter)
            {
                area = length * width;
                perimeter = 2 * (length + width);
            }
    }
}
}