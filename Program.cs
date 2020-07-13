using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, sum = 0;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                sum = sum * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Its reverse is  = {0}", sum);
            if (temp == sum)
                Console.WriteLine("Number is a palindrome");
            else
                Console.WriteLine("Number is not a palindrome");
            Console.ReadLine();
        }
    }
}
