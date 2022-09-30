using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressverwaltung
{
    public class Adressbuch
    {
        public Adressbuch(Type adressType)
        {
        }

        public enum AdressTypeEnum
        {
            Kunden,
            Lieferanten,
            Privat
        }
    }
}