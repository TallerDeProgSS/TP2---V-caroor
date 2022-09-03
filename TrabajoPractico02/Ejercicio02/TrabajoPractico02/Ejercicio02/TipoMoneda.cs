using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class TipoMoneda
    {
        private Cuenta enDolares;
        private Cuenta enPesos;


        public TipoMoneda()     //registra los tipos de monedas
        {
            Moneda objMonedaDolar = new Moneda("USD", "Dolar", "$");        //CodigoISO, nombre y simbolo del dolar
            enDolares = new Cuenta(objMonedaDolar);

            Moneda objMonedaPesoArg = new Moneda("ARS", "Peso Argentino", "$");  //CodigoISO, nombre y simbolo del peso argentino
            enPesos = new Cuenta(objMonedaPesoArg);
        }



       
    }
}
