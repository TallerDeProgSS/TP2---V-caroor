using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{

    internal class Banca
    {
        string numero;
        string titular;

        public Banca(string pNumero, string pTitular)       
        {
            this.numero = pNumero;
            this.titular = pTitular;
        }

        public string Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }





        //división para las cuentas diferentes (dolares y pesos)

        private Cuenta enDolares;
        private Cuenta enPesos;

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
