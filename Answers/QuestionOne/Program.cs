using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the main number :");
                int mainNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number that you want to concatenate :");
                int secondaryNumber = Convert.ToInt32(Console.ReadLine());

                int savedNumber = secondaryNumber;
                while (secondaryNumber > 0)
                {
                    secondaryNumber /= 10;
                    mainNumber *= 10;
                }
                mainNumber += savedNumber;
                Console.WriteLine(mainNumber);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);// or anything you want to do
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
