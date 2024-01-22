using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.If_statements2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false; ;
            if (isMale)
            {
                Console.WriteLine("You are male.");

            }
            else
            {
                Console.WriteLine("You are female.");
            }
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and you are also tall.");
            }
            else if (!isTall && isMale)
            {
                Console.WriteLine("You are not tall but you are a male.");
            }
            else
            {
                Console.WriteLine("You are either not tall or not a male, so you are a female");
            }









        }
    }
}
