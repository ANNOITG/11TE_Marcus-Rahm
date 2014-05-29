using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            
        }
    }

    class A
    {
        public void publicA()
        {

        }
        protected void protectedA()
        {

        }
        private void privateA()
        {

        }

    }
    class B : A
    {
        public void publicB()
        {

        }
        protected void protectedB()
        {

        }
        private void privateB()
        {

        }
    }
    class C : B
    {
        public void publicC()
        {

        }
        protected void protectedC()
        {

        }
        private void privateC()
        {

        }

    }
}
