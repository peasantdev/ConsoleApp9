using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOp mathinst = new MathOp();//Instantiate the MathOp class
            Console.WriteLine("Enter an interger: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second integer, or just press enter: ");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathinst.Math(num1, num2);
                Console.WriteLine(num1 + " X " + num2 + " = " + results);
            }
            catch
            {
                int results = mathinst.Math(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }
            Console.ReadLine();
            
        }
    }
}
