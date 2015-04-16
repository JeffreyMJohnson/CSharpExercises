using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ex 1:");
            Example();

            Console.Read();
        }

        private static void Example()
        {
            List<Foo> mylist = new List<Foo>();
            for(int i = 0; i < 10; i++)
            {
                mylist.Add(new Foo(i));
            }
            PrintList(mylist);
            Console.WriteLine("sort descending");
            mylist.Sort();
            PrintList(mylist);

            Foo f2 = mylist[0].Clone() as Foo;
            if (f2 != null)
                f2.Data = 100;
            Console.WriteLine(mylist[0]);
            Console.WriteLine(f2);

        }

        private static void PrintList(List<Foo> list)
        {
            foreach(Foo f in list)
            {
                f.Log();
            }
        }

    }

    public interface ILoggable
    {
        void Log();
    }

    class Foo
        : IComparable<Foo>, IEquatable<Foo>, ICloneable, ILoggable
    {
        private int mData;

        public int Data
        {
            get { return mData; }
            set { mData = value; }
        }

        public Foo(int data)
        {
            mData = data;
        }

        public override string ToString()
        {
            return "Foo [Data:" + mData.ToString() + " ]";
        }

        public int CompareTo(Foo other)
        {
            //descending order
            if (other.Equals(null)) return 1;
            if (this.Equals(other)) return 0;
            if (this.Data > other.Data) return -1;
            if (this.Data < other.Data) return 1;
            return 0;
        }

        public bool Equals(Foo other)
        {
            if (other == null) return false;
            return this.Data.Equals(other.Data);
        }

        public override bool Equals(object obj)
        {
            if (obj.Equals(null)) return false;
            Foo other = obj as Foo;
            if (other.Equals(null)) return false;
            return this.Data.Equals(other.Data);
        }

        public static bool operator == (Foo lhs, Foo rhs)
        {
            if ((object)lhs == null || (object)rhs == null)
            {
                return Object.Equals(lhs, rhs);
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Foo lhs, Foo rhs)
        {
            return !(lhs.Equals(rhs));
        }

        public Object Clone()
        {
            return new Foo(this.Data);

        }

        public void Log()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
