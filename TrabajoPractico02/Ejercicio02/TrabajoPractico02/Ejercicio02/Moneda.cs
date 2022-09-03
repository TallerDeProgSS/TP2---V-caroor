using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Moneda
    {
        private string iCodigoISO; 
        private string iNombre;     
        private string iSimbolo;    

        public Moneda(string pCodigoISO, string pNombre, string pSimbolo) //para verificar el tipo de moneda
        {
            iCodigoISO = pCodigoISO; //codigo de la moneda: puede ser USD o ARS
            iNombre = pNombre;      //nombre de moneda: Dolar o Peso Argentino
            iSimbolo = pSimbolo;    //simbolo: $
        }

        public string CodigoISO     //codigo de la moneda
        {
            get { return this.iCodigoISO ; }
            set { this.iCodigoISO = value; }
        }

        public string Simbolo       //Simbolo de la moneda
        {
            get {  return this.iSimbolo; }
            set {  this.Simbolo = value; }
        }
        public string Nombre        //Nombre de la moneda
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

    }
}
