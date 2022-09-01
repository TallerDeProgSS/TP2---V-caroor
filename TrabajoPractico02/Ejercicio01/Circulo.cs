using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Circulo
    {
        private double iRadio;
        private double x, y;


        public Circulo(Punto pCentro, Punto pRadio)
        {
            this.iRadio = pCentro.calcularDistanciaDesde(pRadio);
        }
        
        public double Area
        {
            get { return Math.Pow(this.iRadio, 2) * System.Math.PI; }
            set { this.iRadio = value; }   

        }

        public double Perimetro
        {
            get { return 2 * this.iRadio * Math.PI; }
            set { this.iRadio = value; }
        }
    }
}
