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


            // Calculator
            //Calculator calculator = new Calculator();
            //Console.Write("Number 1 : ");
            //string number1 = Console.ReadLine();
            //Console.Write("Number 2 : ");
            //string number2 = Console.ReadLine();
            //Console.Write("Choose your operator : ");
            //string choose = Console.ReadLine();

            //if(choose == "+")
            //{
            //    calculator.Plus(number1, number2);
            //}
            //else if(choose == "-")
            //{
            //    calculator.Minus(number1, number2);
            //}
            //else if(choose == "*")
            //{
            //    calculator.Multiplied(number1, number2);
            //}
            //else if(choose == "%")
            //{
            //    calculator.Divided(number1, number2);
            //}
            //else 
            //{
            //    Console.WriteLine("Operator not valid");
            //}

            Money money = new Money();
            money.BuyDrink();

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


        class Money
        {
           
            public void BuyDrink()
            {
                decimal money = 0;
                decimal itemPrice = 0;
                string itemName = null;
                bool hasEnteredValue = false;
                int chooiceNumber;
                bool isValidItem = false;
                int choiceSaldo;
                decimal topUpSaldo = 0;
                decimal secMoney = 0;

                while(money >= 0)
                {
                    while (!hasEnteredValue)
                    {
                        Console.Write("Enter how much money you have : ");
                        hasEnteredValue = decimal.TryParse(Console.ReadLine(), out money);
                        if (!hasEnteredValue)
                        {
                            Console.WriteLine("Invalid your input");
                        }
                    }

                    while (money >= 3)
                    {
                        Console.WriteLine("Your money ${0}, choose one", money);
                        Console.WriteLine("[1] Teh Pucuk $10");
                        Console.WriteLine("[2] Floridina $12");
                        Console.WriteLine("[3] Frestea $9");
                        Console.WriteLine("[4] Teh Sisri $3");

                        Console.Write(": ");

                        if (int.TryParse(Console.ReadLine(), out chooiceNumber))
                        {
                            isValidItem = false;
                            if (chooiceNumber == 1)
                            {
                                itemPrice = 10;
                                itemName = "Teh Pucuk";
                                isValidItem = true;
                            }
                            if (chooiceNumber == 2)
                            {
                                itemPrice = 12;
                                itemName = "Floridina";
                                isValidItem = true;
                            }
                            if (chooiceNumber == 3)
                            {
                                itemPrice = 9;
                                itemName = "Frestea";
                                isValidItem = true;
                            }
                            if (chooiceNumber == 4)
                            {
                                itemPrice = 3;
                                itemName = "Teh Sisri";
                                isValidItem = true;
                            }

                            if (isValidItem)
                            {
                                if (itemPrice > money)
                                {
                                    Console.WriteLine("Your money not enough to buying {0}", itemName);

                                }
                                else
                                {
                                    Console.WriteLine("You purchase a {0} for ${1}", itemName, itemPrice);
                                    money -= itemPrice;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }

                    //Console.WriteLine("Your money not enough buy drink now");

                    if (money <= 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your money ${0}", money);
                        Console.Write("Your money ${} topup saldo? 1/2: ");

                        if (int.TryParse(Console.ReadLine(), out chooiceNumber))
                        {
                            isValidItem = false;
                            if (chooiceNumber == 1)
                            {
                                isValidItem = true;
                            }

                            if (isValidItem)
                            {
                                //if (itemPrice > money)
                                //{
                                //    Console.WriteLine("Your money not enough to buying {0}", itemName);
                                //}

                                Console.Write("Enter how much topup money : ");
                                //var data = Console.ReadLine();
                                hasEnteredValue = decimal.TryParse(Console.ReadLine(), out topUpSaldo);
                                if (!hasEnteredValue)
                                {
                                    Console.WriteLine("Invalid your input");
                                }
                                else
                                {
                                    //topUpSaldo = decimal.Parse(data);
                                    Console.WriteLine("You topup money ${0}", topUpSaldo);
                                    money += topUpSaldo;
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
