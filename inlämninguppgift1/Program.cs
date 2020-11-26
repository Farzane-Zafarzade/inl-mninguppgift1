using System;
using System.Collections.Generic;
using System.Collections;


namespace ekvationen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ope = new string[3];
            int[] num = new int[4];
            ArrayList sum = new ArrayList();
            int total = 0;
            string cond;

            do
            {

                Console.Write(" > Enter first operator: ");
                ope[0] = Console.ReadLine();
                Console.Write(" > Enter second operator: ");
                ope[1] = Console.ReadLine();
                Console.Write(" > Enter first term: ");
                num[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write(" > Enter second term: ");
                num[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write(" > Enter third term: ");
                num[2] = Convert.ToInt32(Console.ReadLine());



                string[] ekv = new string[7];
                ekv[0] = Convert.ToString(num[0]);
                ekv[1] = ope[0];
                ekv[2] = Convert.ToString(num[1]);
                ekv[3] = ope[1];
                ekv[4] = Convert.ToString(num[2]);
                ekv[5] = "=";





                if (ope[0] == "+" && ope[1] == "+")
                {
                    num[3] = num[0] + num[1] + num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "+" && ope[1] == "-")
                {

                    num[3] = num[0] + num[1] - num[2];
                    ekv[6] = Convert.ToString(num[3]);



                }

                else
                    if (ope[0] == "+" && ope[1] == "*")
                {
                    num[3] = num[0] + num[1] * num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "+" && ope[1] == "/")
                {
                    num[3] = num[0] + num[1] / num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "-" && ope[1] == "+")
                {
                    num[3] = num[0] - num[1] + num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "-" && ope[1] == "-")
                {
                    num[3] = num[0] - num[1] - num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "-" && ope[1] == "*")
                {
                    num[3] = num[0] - num[1] * num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "-" && ope[1] == "/")
                {
                    num[3] = num[0] - num[1] / num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "*" && ope[1] == "+")
                {
                    num[3] = num[0] * num[1] + num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "*" && ope[1] == "-")
                {
                    num[3] = num[0] * num[1] - num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "*" && ope[1] == "*")
                {
                    num[3] = num[0] * num[1] * num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "*" && ope[1] == "/")
                {
                    num[3] = num[0] * num[1] / num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }


                else
                    if (ope[0] == "/" && ope[1] == "+")
                {
                    num[3] = num[0] / num[1] + num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "/" && ope[1] == "-")
                {
                    num[3] = num[0] / num[1] - num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "/" && ope[1] == "*")
                {
                    num[3] = num[0] / num[1] * num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                else
                    if (ope[0] == "/" && ope[1] == "/")
                {
                    num[3] = num[0] / num[1] / num[2];
                    ekv[6] = Convert.ToString(num[3]);

                }

                sum.Add(num[3]);


                Console.Write(" > ");
                for (int i = 0; i < 7; i++)
                {

                    Console.Write(ekv[i]);
                }

                Console.WriteLine();


                if (num[3] < 100)
                {
                    Console.WriteLine(" > ”The Sum is less then a hundred”");
                }
                else
                    if (num[3] > 100)
                {
                    Console.WriteLine(" > ”The Sum is More then a hundred”");
                }
                else
                    if (num[3] == 100)
                {
                    Console.WriteLine(" > ”Cool, now you have a hundred, clap clap”");
                }

                Console.WriteLine(" > Another try? Y / N");
                cond = Console.ReadLine();


            } while (cond == "y");

            for (int i = 0; i < sum.Count; i++)
            {


                int sum1 = (int)sum[i];
                total = total + sum1;
            }

            Console.Write("> Thank you for playing. The Sum of all round is {0} . Bye", total);
           
        }
    }
}

