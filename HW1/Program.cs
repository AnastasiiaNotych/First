using System;

namespace Console1
{
    class Program
    {
        static void CalculateTheEquation()
        {
            Console.WriteLine("Calculate the equation");
            Console.WriteLine("Please enter a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b");
            double b = double.Parse(Console.ReadLine());

            double c = (5 * a + b * b) / (b - a);

            Console.WriteLine(c);
        }
        static void ChangingValues()
        {
            Console.WriteLine("Changing values");
            Console.WriteLine("Please enter first string");
            string a = (Console.ReadLine());
            Console.WriteLine("Please enter second string");
            string b = (Console.ReadLine());

            string c = a;
            a = b;
            b = c;

            Console.WriteLine(a + " and " + b);
        }
        static void CalculateTheDivisionAndTheReminder()
        {
            Console.WriteLine("Calculate the division and the reminder");
            Console.WriteLine("Please enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b");
            int b = int.Parse(Console.ReadLine());

            int c = a / b;
            int d = a % b;

            Console.WriteLine("division result: " + c);
            Console.WriteLine("remainder of the division: " + d);
        }
        static void CalculateTheEquation2()
        {
            Console.WriteLine("Calculate the equation 2");
            Console.WriteLine("Please enter a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter c");
            double c = double.Parse(Console.ReadLine());

            double d = (c - b) / a;

            Console.WriteLine("a*x+b=c");
            Console.WriteLine("x=: " + d);
        }
        static void ShowTheEquationsOfTheLine()
        {
            Console.WriteLine("Show the equations of the line");
            Console.WriteLine("Please enter X1");
            double X1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y1");
            double Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter X2");
            double X2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y2");
            double Y2 = double.Parse(Console.ReadLine());

            double a = (Y2 - Y1) / (X2 - X1);
            double b = -(X1 * Y2 - X2 * Y1) / (X2 - X1);

            Console.WriteLine("Y=" + a + "*X" + b);
        }
        static void Main(string[] args)
        {

        }
    }
}