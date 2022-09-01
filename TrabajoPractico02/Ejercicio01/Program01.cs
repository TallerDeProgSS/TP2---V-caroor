using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program01
    {
        static void Main(string[] args)
        {

            //int x, y, area, perim;
           
            Console.WriteLine("1. Distancia entre dos puntos");        
            Console.WriteLine("2. Area y perimetro de un circulo");
            Console.WriteLine("3. Area y perimetro de un triangulo");
            Console.Write("Ingrese un numero: ");       //seleccionar que operación desea hacer
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            
            switch(num)
            {
                case 1: // para calcular la distancia entre dos puntos se solicita que se ingrese el eje x e y de ambos puntos.
                    Console.Write("Ingrese eje x del primer punto: ");
                    double x1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese eje y del primer punto: ");
                    double y1= Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();  //espacio

                    Console.Write("Ingrese eje x del segundo punto: ");
                    double x2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese eje y del segundo punto: ");
                    double y2 = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Punto objPunto1 = new Punto(x1,y1);
                    Punto objPunto2 = new Punto(x2,y2);
                    //objPunto1.calcularDistanciaDesde(objPunto2);  // calcula la distancia entre ambos puntos

                    Console.WriteLine("Distancia entre ambos puntos: " + objPunto1.calcularDistanciaDesde(objPunto2));      //muestra la distancia
                    Console.ReadLine();


                    break;
                
                case 2:
                            //solicita los 2 puntos
                    Console.Write("Ingrese eje x del primer punto: ");
                    double cx1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese eje y del primer punto: ");
                    double cy1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();  //espacio

                    Console.Write("Ingrese eje x del segundo punto: ");
                    double cx2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese eje y del segundo punto: ");
                    double cy2 = Convert.ToInt32(Console.ReadLine());
 
                    Console.Clear(); //limpia la pantalla

                    Punto objPuntoC1 = new Punto(cx1, cy1);
                    Punto objPuntoC2 = new Punto(cx2, cy2);

                    Circulo objCirculo = new Circulo(objPuntoC1, objPuntoC2);

                    Console.WriteLine("El área es: " + objCirculo.Area);    //va la clase circulo para calcular el area
                    Console.WriteLine("El perímetro es: " + objCirculo.Perimetro);  //va la clase circulo para calcular el perimetro

                    break;

                case 3:
                            //solicita los 3 puntos
                    Console.Write("Ingrese eje x del primer punto: ");
                    double tx1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese eje y del primer punto: ");
                    double ty1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();  //espacio

                    Console.Write("Ingrese eje x del segundo punto: ");
                    double tx2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese eje y del segundo punto: ");
                    double ty2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();  //espacio

                    Console.Write("Ingrese eje x del tercer punto: ");
                    double tx3 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese eje y del tercer punto: ");
                    double ty3 = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Punto objPuntoT1 = new Punto(tx1, ty1);
                    Punto objPuntoT2 = new Punto(tx2, ty2);
                    Punto objPuntoT3 = new Punto(tx3, ty3);

                    Triangulo objTriangulo = new Triangulo(objPuntoT1, objPuntoT2, objPuntoT3);

                    Console.WriteLine("El área es: " + objTriangulo.Area);
                    Console.WriteLine("El perímetro es: " + objTriangulo.Perimetro);


                    break;

                    default:
                    Console.WriteLine("La opción no se encuntra registrada");
                    break;

            }
        }
    }
}
