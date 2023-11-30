using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            // Print name method
            //PrintName print = new PrintName();
            //Console.Write("My name is : ");
            //string name = Console.ReadLine();
            //print.Print(name);

            Calculator calculator = new Calculator();
            Console.Write("Number 1 : ");
            string number1 = Console.ReadLine();
            Console.Write("Number 2 : ");
            string number2 = Console.ReadLine();
            Console.Write("Choose your operator : ");
            string choose = Console.ReadLine();

            if(choose == "+")
            {
                calculator.Plus(number1, number2);
            }
            else if(choose == "-")
            {
                calculator.Minus(number1, number2);
            }
            else if(choose == "*")
            {
                calculator.Multiplied(number1, number2);
            }
            else if(choose == "%")
            {
                calculator.Divided(number1, number2);
            }
            else 
            {
                Console.WriteLine("Operator not valid");
            }
            

            Console.ReadKey();
        }

        // print name method
        class PrintName
        {
            public void Print(string name) 
            {
                if (name.Equals("irgi"))
                {
                    Console.WriteLine("Myname is irgi");
                }

                Console.WriteLine("Hello my name is {0}", name);
            }
        }

        class Calculator
        {
            public void Plus(string number1, string number2)
            {
                int numConvert1 = int.Parse(number1);
                int numConvert2 = int.Parse(number2);
                int data = numConvert1 + numConvert2;
                Console.WriteLine("Result : {0}", data);
            }

            public void Minus(string number1, string number2)
            {
                int numConvert1 = int.Parse(number1);
                int numConvert2 = int.Parse(number2);
                int data = numConvert1 - numConvert2;
                Console.WriteLine("Result : {0}", data);
            }

            public void Multiplied(string number1, string number2) 
            {
                int numConvert1 = int.Parse(number1);
                int numConvert2 = int.Parse(number2);
                int data = numConvert1 * numConvert2;
                Console.WriteLine("Result : {0}", data);
            }

            public void Divided(string number1, string number2)
            {
                int numConvert1 = int.Parse(number1);
                int numConvert2 = int.Parse(number2);
                int data = numConvert1 % numConvert2;
                Console.WriteLine("Result : {0}", data);
            }
        }
    }
}
