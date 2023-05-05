using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class MathOp
    {
        public void PrintMath(int num1, int num2 = 1)
        {
            try
            {
                int sum = num1 + num2;
                Console.WriteLine("The value of {0} + {1} = {2}", num1, num2, sum);
                Console.ReadLine();
                Console.WriteLine(num2);
            }
            catch
            {
                int sum2 = num1 + 1;
                Console.WriteLine("The value of {0} + 1 = {1}", num1, sum2);
                Console.ReadLine();
            }
        }
    }
}
