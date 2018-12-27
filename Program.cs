using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Home_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Random random = new Random();
            int maxNumber = 100;
            Console.WriteLine("Rundom numbers: "+random.Next(maxNumber) + "  " + random.Next(maxNumber) + "  " + random.Next(maxNumber));

            // 2.
            int[] magicNumbers = { 5, 10, 21 };
            foreach (var numbers in magicNumbers)
            {
                Console.WriteLine(numbers + " ");
            }

            // 3.
            Console.WriteLine("Enter value of santimeters");
            int santimeters = Convert.ToInt32(Console.ReadLine());
            double meters = (double)santimeters / 100;
            Console.WriteLine("Value of meters: " + meters);

            // 4.
            Console.WriteLine("Enter amount days");
            int days = Convert.ToInt32(Console.ReadLine());
            int weeks = days / 7;
            Console.WriteLine("Amount of weeks: " + weeks);

            // 5.
            Console.WriteLine("Enter value of Two Digit Number");
            int twoGigitNumber = Convert.ToInt32(Console.ReadLine());
            int tens = (twoGigitNumber / 10) % 10;
            int ones = twoGigitNumber % 10;
            double sum = tens + ones;
            double composition = tens * ones;
            Console.WriteLine("Value of Tens: " + tens);
            Console.WriteLine("Value of Ones: " + ones);
            Console.WriteLine("Value of the Sum: " + sum);
            Console.WriteLine("Value of Composition: " + composition);

            // 6.
            bool a = true, b = false, c = false;
            if (a || b)
            {
                Console.WriteLine("a || b - true");
            }
            else
            {
                Console.WriteLine("a || b - false");
            }

            if (a && b)
            {
                Console.WriteLine("a && b - true");
            }
            else
            {
                Console.WriteLine("a && b - false");
            }

            if (b || c)
            {
                Console.WriteLine("b || c - true");
            }
            else
            {
                Console.WriteLine("b || c - false");
            }

            // 7.
            Console.WriteLine("Enter radious, before side");
            double radius = Convert.ToDouble(Console.ReadLine());
            double side = Convert.ToDouble(Console.ReadLine());

            double squareQuadrate = side * side;
            double squareCircle = Math.PI * (radius * radius);

            Console.WriteLine("Square of quadrate - " + squareQuadrate);
            Console.WriteLine("Square of circle - " + squareCircle);

            // 8.
            Console.WriteLine("Enter volume and mass of two bodies");
            double firstVolume = Convert.ToDouble(Console.ReadLine());
            double firstMass = Convert.ToDouble(Console.ReadLine());

            double secondVolume = Convert.ToDouble(Console.ReadLine());
            double secondMass = Convert.ToDouble(Console.ReadLine());

            double firstDensity = firstMass / firstVolume;
            double secondDensity = secondMass / secondVolume;
            if (firstDensity > secondDensity)
            {
                Console.WriteLine("First density more than second density");
            }
            else if (firstDensity < secondDensity)
            {
                Console.WriteLine("Second density more than first density");
            }
            else
            {
                Console.WriteLine("First density equal second density");
            }

            // 9.
            Console.WriteLine("Enter resistance and voltage");
            double resistance = Convert.ToDouble(Console.ReadLine());
            double voltage = Convert.ToDouble(Console.ReadLine());
            double amperage = voltage / resistance;
            Console.WriteLine("Ampertage - " + amperage);

            // 10.
            int from = 20;
            int to = 50;
            Console.WriteLine("Begin");
            for (int i = from; i < to; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End");

            Console.WriteLine("Enter 'to'");
            from = 10;
            to = Convert.ToInt32(Console.ReadLine());
            while (to < from) 
            {
                Console.WriteLine("Error input! Try agane!");
                to = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Begin");
            for (int i = from; i < to; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.WriteLine("End");

            Console.WriteLine("Enter 'from'");
            to = 50;
            from = Convert.ToInt32(Console.ReadLine());
            while (to < from) 
            {
                Console.WriteLine("Error input! Try agane!");
                from = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Begin");
            for (int i = from; i < to; i++)
            {
                Console.WriteLine(i * i * i);
            }
            Console.WriteLine("End");

            Console.WriteLine("Enter 'from' and 'to'");
            from = Convert.ToInt32(Console.ReadLine());
            to = Convert.ToInt32(Console.ReadLine());
            while (to < from)
            {
                Console.WriteLine("Error input! Try agane!");
                from = Convert.ToInt32(Console.ReadLine());
               to = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Begin");
            for (int i = from; i < to; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End");
            Console.Read();
        }
    }
}
////