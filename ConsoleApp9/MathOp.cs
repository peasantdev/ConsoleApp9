using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class MathOp //Created a class with a void method.
    {
        public void PrintMath(int num1, int num2 = 1)
        {
            try //Have to use a try/catch here or it will read all lines or would need another method.
            {
                int sum = num1 + num2;
                Console.WriteLine("The value of {0} + {1} = {2}", num1, num2, sum);//Specifying the parameters by name.
                Console.ReadLine();
                Console.WriteLine(num2);
            }
            catch
            {
                int sum2 = num1 + 1;
                Console.WriteLine("The value of {0} + 1 = {1}", num1, sum2);//Specifying the parameters by name.
                Console.ReadLine();
            }
        }
    }
}
