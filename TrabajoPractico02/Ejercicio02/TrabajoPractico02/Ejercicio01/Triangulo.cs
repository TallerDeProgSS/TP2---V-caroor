using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Triangulo
    {
        private double a;
        private double b;
        private double c;
        private double paraArea;

        Punto punto1;
        Punto punto2;
        Punto punto3;
        public Triangulo(Punto Punto1, Punto Punto2, Punto Punto3)
        {
            punto1 = Punto1;
            punto2 = Punto2;
            punto3 = Punto3;
            a = punto1.calcularDistanciaDesde(punto2);
            b = punto2.calcularDistanciaDesde(punto3);
            c = punto3.calcularDistanciaDesde(punto1);
            paraArea = (a + b + c) / 2;
        }

        public double Area
        {
            
            get {return Math.Sqrt(this.paraArea * (this.paraArea - this.a) * (this.paraArea - this.b) * (this.paraArea - this.c)); }
            set { this.a = value; this.b = value; this.c = value; this.paraArea = value; }

        }

        public double Perimetro
        {
            get { return (this.a + this.b + this.c); }
            set { this.a = value; this.b = value; this.c = value; }
        }
    }
}

