using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;

            Console.WriteLine("Enter a whole number");
            a = Convert.ToInt32(Console.ReadLine());
            //converts string from user to number by using convert.ToInt32()
            Console.WriteLine("Enter another whole number to add");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+ "+" +b+ " = " +(a+b));
            /*only adds two numbers*/
            Console.ReadLine();
        }
    }
}
