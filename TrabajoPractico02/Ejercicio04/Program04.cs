using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program04
    {
        static void Main(string[] args)
        {
            Fachada objFachada = new Fachada();
            List<Juego> listaJugadas = new List<Juego>();

            int num;

            do
            {
                

                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Modificar cantidad máxima de fallos");
                Console.WriteLine("3.Top 5 partidas ganadas al menor tiempo ");
                Console.Write("Seleccione un número: ");    //seleccionar sobre que cuenta desea operar
                num = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (num)         //dependiendo la opción que se enumere tendrá un nuevo menu seleccionable
                {
                    case 1:
                        {

                            Juego objJuego = objFachada.jugandoF();
                            if (objJuego.TerminoJugada == true)  //si gano el juego entonces lo puede agregar a la lista
                            {
                                listaJugadas.Add(objJuego);

                            }
                        }
                        break;

                    case 2:
                        {
                            objFachada.Intentos();                        
                        }
                        break;

                    case 3:
                        {
                            objFachada.MejoresJugadores(listaJugadas);
                        }
                        break;
                    case 4:
                        {
                           //vacio para volver atrás
                        }
                        break;

                }

            } while (num != 4);
        }
    }
}

    
