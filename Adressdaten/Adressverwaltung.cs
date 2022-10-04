using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressverwaltung
{
    public class Adressbuch
    {
        //Konstruktor
        public Adressbuch(Type adressType)
        {
        }

        //Enum für Combobox
        public enum AdressTypeEnum
        {
            Kunden,
            Lieferanten,
            Privat
        }
    }
}