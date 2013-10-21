using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Work4
{
    class student : Person
    {
        public List<Grades> grades = new List<Grades>();
        private string Class;
        public string getClass() { return Class; }
        public void setClass(string Class) { this.Class = Class; }
        public student()
        {

        }
        public student(string name, string pnr, string telenr, string adress, string klass)
        {
            Class = klass;
            setName(name);
            setPnr(pnr);
            setTeleNr(telenr);
            setAdress(adress);
        }

    }
}
