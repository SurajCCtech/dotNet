using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*
        static void Greeting()
        {
            .WriteLine("Good Evening everyone!");
        }
        static void Greeting1(string person)
        {
            Console.WriteLine("Good Evening " + person + "!");
        }
        */

        static int summation(int a,int b, int c)
        {
            int sum = (a + b + c);
            return sum;
        }

        static int summation(int x, int y)
        {
            int sum = (x + y);
            return sum;
        }
        static void Main(string[] args)
        {
            //                                                   -----  INPUT- OUTPUT TO CONSOLE --------

            // Console.WriteLine("Hello World!");     // Create new line "WriteLine()"
            // Console.Write("Hello CCtech!");        // Will not create new line  "Write()"
            // Console.WriteLine("Learning C#");
            // Console.ReadLine();                   // Take input from the user //

            //                                                  ------ CONCATENATE STRINGS  --------

            // Console.WriteLine("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("My name is "+ name);
            // Console.ReadLine();

            //                                                  ------ TYPECASTING USING FUNCTIONS ------

            // Console.WriteLine("Add a number to a string: ");
            // string num = Console.ReadLine();
            // Console.WriteLine("Addition of numbers is " + (Convert.ToInt32(num) + 50));
            // Console.ReadLine();

            //                                                 ------ INTERPOLATION IN THE STRINGS ------

            // string name = Console.ReadLine();
            // string marks = Console.ReadLine();
            // Console.WriteLine($"My name is {name} and I got {marks} marks out of 100.");
            // Console.ReadLine();

            //                                                 ----- DECISION CONTROL ------

            // int age = 20;
            // if (age > 21)
            // {
            //     Console.WriteLine("You can drink Alcohol.");
            // }
            // else
            // {
            //     Console.WriteLine("You can't drink Alcohol.");
            // }
            // Console.ReadLine();

            //                                                 ------ METHODS -------

            /*
            Greeting();
            
            Greeting1("Ankit");
            Console.ReadLine();
            */

            //                                                 ------- METHOD OVERLOADING  -------

            /*Console.WriteLine(summation(15, 20, 35));
            Console.WriteLine(summation(40, 110));
            Console.ReadLine();

            */

            //                                                 ------- OBJECT CREATION AND USE  --------
            DemoClass demo = new DemoClass();
            Console.WriteLine(demo.Add());
            Console.ReadLine();



        }
    }
}
