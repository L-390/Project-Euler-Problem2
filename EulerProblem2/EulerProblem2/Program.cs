using System;

namespace EulerProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 1;
            int sum = 0;
            int i = 0;

            while(i == 0)
            {
                number1 = number1 += number2;

                number2 = number2 += number1;
                
                if(number1 <= 4000000 && number2 <= 4000000)
                {
                    Console.WriteLine(number1);
                    Console.WriteLine(number2);

                    if ((number1 % 2) == 0)
                    {
                        sum += number1;   
                    }

                    if ((number2 % 2) == 0)
                    {       
                        sum += number2;
                    }
                }
                else
                {
                    i = 1;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
