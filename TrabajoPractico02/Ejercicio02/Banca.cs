using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
   
    internal class Banca
    {
       


        
        //división para las cuentas diferentes (dolares y pesos)

        private Cuenta enDolares;
        private Cuenta enPesos;


        public Banca()     //registra los tipos de monedas
        {
            Moneda objMonedaDolar = new Moneda("USD", "Dolar", "$");        //CodigoISO, nombre y simbolo del dolar
            enDolares = new Cuenta(objMonedaDolar);

            Moneda objMonedaPesoArg = new Moneda("ARS", "Peso Argentino", "$");  //CodigoISO, nombre y simbolo del peso argentino
            enPesos = new Cuenta(objMonedaPesoArg);
        }



        public Cuenta EnPesos       
        {
            get { return this.enPesos; }
            set { this.enPesos = value; }
        }

        public Cuenta EnDolares
        {
            get { return this.enDolares; }
            set { this.enDolares = value; }
        }

    }
}
