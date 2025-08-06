using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils
{
    public static class Validator
    {
        //Objeto validador de datos de entrada
        //Siempre culquier atributo o metodo debe ser definido como static tambien

        public static bool IsDecimal(string texto){
            if (string.IsNullOrEmpty(texto))
            {
                return false;
            }

            if(!decimal.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out _)){
                return false;
            }

            return true;
        }
    }
}
