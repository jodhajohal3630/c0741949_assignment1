using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0741949
{
    class Program
    {
        static void Main(string[] args)
        {
            // print hello and input my name
            Console.WriteLine("enter your name");
            var name = Console.ReadLine();
            Console.WriteLine(name + "/n hello");

            //B
            Console.WriteLine("Enter the first number you want to +, * or /");
            var e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the other number you want to *,/ and +");
            var f = Convert.ToInt32(Console.ReadLine());
            int sum = Convert.ToInt32(e + f);

            Console.WriteLine("the sum is" + sum);
            Console.WriteLine("the  is" + (e*f));
            Console.WriteLine("the sum is" + (e/f));

            //c
            int g = 1;
            int h = 2;
            Console.WriteLine("before swap two numbers g=" + g + "g=" + h);
            g = g * h;
            h = g / h;
            g = g / h;

            Console.WriteLine("after swap two numbers g=" + g + "g=" + h);

            //d
            Console.WriteLine("enter three numbers you want to multiply");
            int a  = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("answer of multiplication is" + (a*b*c));
            //e
            Console.WriteLine("enter the number for you want to see multiplication table");
            double number = Convert.ToDouble(Console.ReadLine());
            for (int x=1; x<=9; x++)
            {
                Console.WriteLine(number + "*" + x + (number * x));

            }

            //f
            Console.WriteLine("enter first number:");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter second number:");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter third number:");
            double o = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter fourth number:");
            double p = Convert.ToDouble(Console.ReadLine());

            double Average = (m * n * o * p) / 2;
            Console.WriteLine("average of four numbers" + Average);

            //g

            Console.WriteLine("enter your user name");
            string user = Console.ReadLine();
            Console.WriteLine(" \" " + user + " you look older than 20 \" ");

            //h
            Console.WriteLine("enter first number:");
            int i  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int j = Convert.ToInt32(Console.ReadLine());

            int sumf = i + j;

            if (i == j)
            {
                int sumg = 3 * sumf;
            }
            else
            {
                Console.WriteLine(sumf);
            }
            //i
            Console.WriteLine("enter int number");
            int mynumber = Convert.ToInt32(Console.ReadLine());
            if (mynumber > 20 || mynumber < 100)
            {
                Console.WriteLine("the integer number entered is between 20 and 100");
            }

            //j
            int t = 0;
            for (int y = 1; y <= 10; y++)
            {
                t = t + y;

                Console.WriteLine(i);
            }
            Console.WriteLine("sum is" + t);

            //k
            int aa = 0;
            int bb = 4;
            while (aa <= 10)
            {
                bb += aa;
                aa++;
            }
            Console.WriteLine("the sum is" + bb);

            //l
            Console.WriteLine(" please enter first number:");
            int cc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" please enter second number:");
            int dd = Convert.ToInt32(Console.ReadLine());

            if (cc == dd)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            //m
            Console.WriteLine("enter first number:");
            double ee = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter second number:");
            double ff = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter third number:");
            double gg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(ee, ff), gg));

              // B-2
            string name = "jodha";
            name = name.Substring(0, name.Length - 12) + "__";
            Console.WriteLine(name);
            // B-3
            string ijk = "efgh";
            string newijk = ijk.Substring(6, 3);
            Console.WriteLine(newijk);


            // b-4
            Console.WriteLine(" please enter natural numbers you want to print");
            int natural = Convert.ToInt32(Console.ReadLine());
            int z = 1;
            for (z = 1; z <= natural; z++)
            {
                Console.WriteLine(z);
            }

            //B Q5
            Console.WriteLine("please enter a string");
            string mystr = Console.ReadLine();
            int countSpaces = mystr.Count(Char.IsWhiteSpace);
            Console.WriteLine("Number of spaces in str are = " + countSpaces);
            
            Console.ReadLine();



        }
    }
}
