using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number :");
            string text =Console.ReadLine();
            int number;
            if (int.TryParse(text,out number))
            {
                char[] digits = text.ToCharArray();
                char firstDigit;
                firstDigit = digits[0];
                digits[0] = digits[digits.Length - 1];
                digits[digits.Length - 1]=firstDigit;
                text = new string(digits);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Could not be convert to valid number");
            }
            
        }
    }
}
