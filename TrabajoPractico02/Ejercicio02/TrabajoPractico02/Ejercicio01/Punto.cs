using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Punto
    {
       
        private double x;
        private double y;

       
        public Punto(double pX, double pY)
        {
            x = pX;
            y = pY;  
        }


        public double calcularDistanciaDesde(Punto punto)
        {

            return Math.Sqrt(Math.Pow((punto.x - x), 2) + Math.Pow((punto.y - y), 2)); //calcula la distancia entre ambos putno

        }
    }
}
