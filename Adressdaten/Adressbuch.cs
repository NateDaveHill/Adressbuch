using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressverwaltung
{
    public class Adressbuch
    {
        public enum AdressType
        {
            Kunden,
            Lieferanten,
            Privat
        }

        public Adressbuch(Adressverwaltung.Adressbuch.AdressType type)
        {
            AddAdress();
            DelAdress();
            CountAdress();
        }

        private void CountAdress()
        {
            throw new NotImplementedException();
        }

        private void DelAdress()
        {
            throw new NotImplementedException();
        }

        private void AddAdress()
        {
            throw new NotImplementedException();
        }
    }
}
