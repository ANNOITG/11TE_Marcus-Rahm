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
            Person p = new Person();
            student s = new student();
            Console.ReadKey();
        }
    }
    class Person
    {
        private string name;
        private string pnr;
        private string telenr;
        private string adress;

        public string getname() { return name; }
        public void setName(string name) { this.name = name; }

        public string getPnr() { return pnr; }
        public void setPnr(string personalNumber) { this.pnr = personalNumber; }

        public string getTeleNr() { return telenr; }
        public void setTeleNr(string telenr) { this.telenr = telenr; }

        public string getAdress() { return adress; }
        public void setAdress(string Adress) { this.adress = Adress; }
    }
    class student : Person
    {
        public student()
        {

        }
        public student(string name, string pnr, string telenr, string adress)
        {
            setName(name);
            setPnr(pnr);
            setTeleNr(telenr);
            setAdress(adress);
        }
        
    }
    class teacher : Person
    {
        public teacher()
        {

        }
        public teacher(string name, string pnr, string telenr, string adress)
        {
            setName(name);
            setPnr(pnr);
            setTeleNr(telenr);
            setAdress(adress);
        }
    }
    class Class
    {
       
    }
}
