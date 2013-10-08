using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            student shitlord = new student("adfgaga", "adfgaga", "adfgaga", "adfgaga", "adfgaga");
            course a = new course();
            Console.WriteLine(shitlord.getname());
            Console.ReadKey();
        }
    }
}
