using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Work4
{
    class teacher : Person
    {
        private int salery;
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
        public void changeSalery(int newSalery)
        {
            salery = newSalery;
        }

    }
}
