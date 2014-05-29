using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            Console.WriteLine(a.OverloadMetod(10, 5));
            Console.ReadKey();
        }
    }
    class A
    {
        public int OverloadMetod(int a, int b)
        {
            return a + b;
        }
        public int OverloadMetod(string a, string b)
        {
            return a.Length + b.Length; 
        }
    }
    class B : A
    {
        public int OverloadMetod(int a, int b)
        {
            return a - b;
        }
    }
}
