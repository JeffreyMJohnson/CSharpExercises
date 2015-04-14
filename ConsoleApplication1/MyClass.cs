using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Experiment with the class. Add more members, constructors. Turn it into a simple calculator 

program that can add, subtract, multiply and divide.
 */
namespace ConsoleApplication1
{
    class MyClass
    {
        private int mResult;
        public int Result
        {
            get { return mResult; }
        }

        public void ClearResult()
        {
            mResult = 0;
        }

        public MyClass Add(int rhs)
        {
            mResult += rhs;
            return this;
        }

        public MyClass Sub(int rhs)
        {
            mResult -= rhs;
            return this;
        }

        public static int SimpleAdditionFunction(int num1, int num2)
        {
           return num1 + num2;
        }

        public static int SimpleSubtraction(int num1, int num2)
        {
            return num1 - num2;
        }

    }

    
}
