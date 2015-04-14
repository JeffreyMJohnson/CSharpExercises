using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            int sum = MyClass.SimpleAdditionFunction(3,4);
            myClass.Add(3).Add(4);

            Console.WriteLine("3 + 4 = " + sum.ToString());
            Console.WriteLine("3 + 4 = " + myClass.Result);

            sum = MyClass.SimpleSubtraction(7, 5);
            myClass.Sub(5);
            Console.WriteLine("7 - 5 = " + sum.ToString());
            Console.WriteLine("7 - 5 = " + myClass.Result);
            Console.Read();
        }
    }
}
