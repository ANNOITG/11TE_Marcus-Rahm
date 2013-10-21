using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace School_Work4
{
    class Program
    {
        static void Main(string[] args)
        {
        while(true){
            var varTableStudents = new Dictionary<string, student>();
            var varTableTeachers = new Dictionary<string, teacher>();
            var varTableCourse = new Dictionary<string, course>();
            Console.Clear();
            Console.WriteLine("Select \n 1. Students  \n 2. Add teacher \n press escape to exit");
            ConsoleKeyInfo c = Console.ReadKey();
            if (c.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Select \n 1. Students \n 2. Add students");
                c = Console.ReadKey();
                if (c.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                }
                else if (c.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    #region Get input info for students
                    Console.Clear();
                    Console.WriteLine("please enter the name of the student");
                    string name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("please enter the pnr for the student");
                    string pnr = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("please enter the telephone number for the student");
                    string tele = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("please enter the adress for the student");
                    string adress = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("please enter the Class for the student");
                    string Class = Console.ReadLine();
                    #endregion

                    varTableStudents[name] = new student(name, pnr, tele, adress, Class);
                }
                
                
            }
            else if(c.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Select \n 1. Teachers \n 2. Add Teacher");
                c = Console.ReadKey();
                if(c.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("select a teacher\n");
                    int a = 0;
                    foreach (var i in varTableTeachers)
                    {
                        a = a++; ;
                        Console.WriteLine(a.ToString() + " " + i.Key.ToString());
                    }
                    Console.ReadKey();
                }
                else if (c.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    #region get input info for teachers
                    Console.Clear();
                    Console.WriteLine("please enter the name of the Teacher");
                    string name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("please enter the pnr for the teacher");
                    string pnr = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("please enter the telephone number for the teacher");
                    string tele = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("please enter the adress for the teacher");
                    string adress = Console.ReadLine();
                    #endregion

                    varTableTeachers[name] = new teacher(name, pnr, tele, adress);
                }
            }
            else if (c.Key == ConsoleKey.D3)
            {
                c = Console.ReadKey();
                if (c.Key == ConsoleKey.D1)
                {
                    string courseName = Console.ReadLine();
                    varTableCourse[courseName] = new course();
                }
                else if (c.Key == ConsoleKey.D2)
                {

                }
            }
            else if (c.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
        }
    }
}
