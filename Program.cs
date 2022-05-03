// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.99;
            bool myBool = false;
            int x = 20;
            int y = 18;
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            Console.WriteLine("This is an int " + myNum);
            Console.WriteLine("This is an double " + myDoubleNum);
            Console.WriteLine("This is an bool " + myBool);
            Console.WriteLine("x is " + x);
            Console.WriteLine("y is " + y);
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            };
            switch (x) {
                case 1:
                    Console.WriteLine("1 is Less Than 15");
                    break;
                case 5:
                    Console.WriteLine("5 is Less Than 15");
                    break;
                case 15: 
                    Console.WriteLine("15 is equal to 15");
                    break;
                case 20: 
                    Console.WriteLine("20 is Greater than 15");
                    break;
            }
        }
    }
}

