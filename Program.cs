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
        

        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int input=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number in main : "+input);
            Increment(input);
            Console.ReadLine();
        }
        static void Increment(int input) 
        { 
            input++;
            Console.WriteLine("value in increament : " +input);
        }
        */

        /*
        static void Main(string[] args) 
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Before increment : " + arr[i]);
            }
            Incement(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("after increment in main : " + arr[i]);
            }
            Console.ReadLine();
        }
        static void Incement(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("after increment : " + arr[i]);
            }
        }
        */

        /*
        static void Main(String[] args)
        {
            int num = 10;
            Console.WriteLine("Value in main before increment : "+num);
            Increment(ref num);
            Console.WriteLine("Value in main after increment : " + num);
            Console.ReadLine();

        }
        static void Increment(ref int num)
        {
            num++;
            Console.WriteLine("after increment in function : "+num);
        }
        */

        static void Main(string[] args) 
        {
            int n1 = 10, n2 = 20, n3 = 30;
            int[] arr1=Increment(n1, n2, n3);
            foreach(int item in arr1)
                Console.WriteLine(item);

        }
        static int[] Increment(int n1, int n2 , int n3)
        {
            n1++;n2++;n3++;
            int[] arr = { n1, n2, n3 };
            return arr;
        }
    }
}
