using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressverwaltung
{
    public class Adressbuch
    {

        public Type adressType;

        public enum AdressTypeEnum
        {
            Kunden,
            Lieferanten,
            Privat
        }

        public Adressbuch(Type adressType)
        {
            
        }

        private void CountAdress()
        {
            throw new NotImplementedException();
        }

        private void DelAdress()
        {
            throw new NotImplementedException();
        }

        
    }
}
