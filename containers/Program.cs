using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ex 1:");
            ArrayExample(10);
            Console.WriteLine("ex 2:");
            ArrayExample2(10);
            Console.WriteLine("ex 4:");
            ArrayExample4();
            Console.WriteLine("ex 5:");
            ArrayExample5();
            
            Console.WriteLine("Ex 1:");
            ListExample();
            Console.WriteLine("Ex 2:");
            ListExample2();
            Console.WriteLine("Ex 3:");
            ListExample3();
            Console.WriteLine("Ex 4:");
            ListExample4();
            */
            Console.WriteLine("Ex 1:");
            DictionaryExample();
            Console.Read();
        }

        public static void DictionaryExample()
        {
            Dictionary<int, string> myDic = new Dictionary<int,string>();
            myDic[0] = "Zero";
            myDic[1] = "One";
            myDic[2] = "Two";
            myDic[3] = "Three";
            myDic[4] = "Four";

            Console.WriteLine("3: " + myDic[3]);

            foreach(var v in myDic)
            {
                Console.WriteLine(v.Value);
            }
        }


        private static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintList(List<Foo> list)
        {
            foreach (Foo item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ListExample()
        {
            List<int> myList = new List<int> { 3, 5, 2, 9 };
            PrintList(myList);
            Console.WriteLine("List[1]: " + myList[1].ToString());

            try
            {
                Console.WriteLine("List[4]: " + myList[4].ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught");
                Console.Write(e.Message + "\n");
            }
        }

        public static void ListExample2()
        {
            List<int> myList = new List<int> { 3, 5, 2, 9 };
            int[] myArray = myList.ToArray();
            PrintArray(myArray);
        }

        public static void ListExample3()
        {
            List<int> myList = new List<int> { 3, 5, 2, 9, 1, 7, 8, 4, 6 };
            PrintList(myList);
            Console.WriteLine("Remove item 4:" + myList[3].ToString() + " and 5:" + myList[4]);
            myList.RemoveRange(3, 2);
            PrintList(myList);
            Console.WriteLine("sort list.");
            myList.Sort();
            PrintList(myList);
        }

        public static void ListExample4()
        {
            List<Foo> myList = new List<Foo>();
            for (int i = 10; i >= 0; i--)
            {
                myList.Add(new Foo(i));
            }
            PrintList(myList);
            Console.WriteLine("sort it");
            myList.Sort();
            PrintList(myList);
        }

        public static void ArrayExample(int size)
        {
            int[] array = new int[size];
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        public static void ArrayExample2(int size)
        {
            int[] array = new int[size];
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            ArrayExample3(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static void ArrayExample3(int[] array)
        {
            Console.WriteLine("ex 3:");
            Console.WriteLine("there are " + array.Length.ToString() + " items in the array.");
            array[2] = 100;

        }

        public static void ArrayExample4()
        {
            Foo[] array = new Foo[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Foo(i);
            }

            foreach (Foo f in array)
            {
                Console.WriteLine(f.Data);
            }
        }

        public static void ArrayExample5()
        {
            int[] a = new int[10];
            int[] b = (int[])a.Clone();
            //int[] b = a;
            b[0] = 100;
            Console.WriteLine("array a");
            PrintArray(a);
            Console.WriteLine("array b");
            PrintArray(b);
        }

        private static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Foo : IComparable
    {
        private int mData;
        public int Data
        {
            get { return mData; }
            set { mData = value; }
        }

        public override string ToString()
        {
            return "Foo [Data: " + Data.ToString() + "]";
        }

        public Foo() { }
        public Foo(int data) { mData = data; }

        public int CompareTo(object obj)
        {
            //if param is null return 1
            if (obj == null) return 1;
            Foo otherFoo = obj as Foo;
            if (otherFoo != null)
            {
                return this.Data.CompareTo(otherFoo.Data);
            }
            else
            {
                throw new ArgumentException("Object is not a Foo");
            }
        }
    }
}
