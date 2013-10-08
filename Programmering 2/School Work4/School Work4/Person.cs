using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Work4
{
    class Person //Lägg alla andra klasser i varsin fil. Person i Person.cs etc...
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
}
