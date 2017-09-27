using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerOsobyCreation
{
    public class Class
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string RodneCislo { get; set; }
        public string DatumNarozeni { get; set; }
        public string Pohlavi { get; set; }

        public Class()
        {
        }

        public override string ToString()
        {
            return "ID" + ID + " Jmeno " + Jmeno + " Prijmeni " + Prijmeni + " Rodne cislo " + RodneCislo + " Datum narozeni " + DatumNarozeni + " Gender " + Pohlavi;
        }
    }
}
