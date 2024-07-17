using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        
         static void Main(string[] args)
         {
             Console.Write("Enter a number: ");
             int number = Convert.ToInt32(Console.ReadLine());
             String primeOrNot=IsPrime(number)? number+" is a prime number.": number + " is not a prime number.";
             Console.WriteLine(primeOrNot);
             Console.ReadLine();

         }

         static bool IsPrime(int num)
         {
              if (num == 2)
                 return true;
             if (num <= 1 || num % 2 == 0)
                 return false;
             for (int i = 3; i <= (num/2); i += 2)
             {
                 if (num % i == 0)
                     return false;
             }
             return true;
         }
        
    }
}
