using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Work4
{
    class student : Person
    {
        public List<List<string>> grades = new List<List<string>>();
        private string Class;
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
