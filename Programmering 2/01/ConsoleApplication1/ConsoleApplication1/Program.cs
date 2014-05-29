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
             A a = new A();
             B b = new B();
            
        }
    }
    class A
    {
        public void publicA()
        {
            AB ab = new AB();
            B b = new B();
            
        }
        protected void protectedA()
        {

        }
        private void privateA()
        {
         
        }
        class AB
        {
            public void publicAB()
            {
                B b = new B();
                b
               
            }
            protected void protectedAB()
            {

            }
            private void privateAB()
            {

            }
        }
    }
    class B : A
    {
        public void publicB()
        {
            A a = new A();
            
        }
        protected void protectedB()
        {

        }
        private void privateB()
        {

        }
    }
}
