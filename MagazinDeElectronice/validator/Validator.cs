using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeElectronice.util
{
    class Validator
    {
        internal static List<string> valideazaComanda(string cantitateString, int rowCount)
        {
            List<string> errors = new List<string>();
            int cantitate;
            Boolean cantitateIsNumber = Int32.TryParse(cantitateString, out cantitate);
            if (!cantitateIsNumber || cantitate <= 0)
                errors.Add("Cantitatea trebuie sa fie numar strict pozitiv"+Environment.NewLine);
            if (rowCount != 1)
                errors.Add("Selecteaza doar un produs!");
            return errors;
        }
    }
}
