using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Fachada
    {
        Palabras objPalabra = new Palabras();
        Juego objJuego = new Juego();

        int maximaFallo = 10;

        public Juego jugandoF()   
        {            
            objJuego = new Juego();
            bool gano = false;
            bool termino = false;


            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();


            string palabra = objPalabra.palabrasRandom();
            string pOculto = objPalabra.palabraOculta(palabra);

            Console.Clear();

            DateTime tiempoIni = DateTime.Now;      //mide el tiempo de inicio
            do
            {

                Console.WriteLine(pOculto);  //muestra la palabra a adivinar pero en guiones.
                Console.WriteLine("Intentos restantes: " + maximaFallo);        //muestra la cantidad de fallos restantes
                Console.WriteLine();

                Console.Write("Letra: ");
                char letra = Convert.ToChar(Console.ReadLine());

                Console.Clear();

                if (!palabra.Contains(letra)) //verifica si la palabra a adivinar contiene dicha letra
                {
                    maximaFallo--; //Si no la contiene, entonces resta la cantidad de fallos
                }

                string siguienteMostrar = "";       //para mostrar en pantalla las letras que si estan

                for (int i = 0; i < palabra.Length; i++)
                {

                    if (letra == palabra[i])   //por cada letra que ingresa, la compara con la palabra a adivinar
                    {
                        siguienteMostrar += letra;  //si esta, entonces la muestra
                    }
                    else
                    {
                        siguienteMostrar += pOculto[i];  // si no esta, entonces no la muestra y agrega el guion
                    }
                }
                pOculto = siguienteMostrar; //se le asigna siguienteMostrar, ya que esta contiene las letras que fueron descubiertas

                Console.Clear();  //limpia la pantalla

                if (!pOculto.Contains("_")) //si la palabra oculta no contiene ningun "_"
                {
                    Console.WriteLine("Acertaste, la palabra era: " + palabra);        //muestra el mensaje que acertó y la palabra 
                    Console.WriteLine();
                    gano = true; //termina el juego ya que ganó
                    termino = true;
                }
                else if (maximaFallo == 0)  //si la cantidad de fallos llegó a 0
                {
                    Console.WriteLine("Perdiste, la palabra era: " + palabra);         //muestra el mensaje que perdió y muestra la palabra
                    Console.WriteLine();
                    gano = false;   //termina el juego aunque haya perdido
                    termino = true;
                }
                


            } while (!termino);

            DateTime tiempoFin = DateTime.Now;      //una vez que el juuego termina, tambien termina el tiempo

            return new Juego(nombre, tiempoIni, tiempoFin, gano);  
        } 




        public void MejoresJugadores (List<Juego> listaJugadas)
        {
            List<Juego> objJuegoList = listaJugadas.OrderBy(i => i.tiempoTot).ToList(); //ordena la lista de menor a mayor tiempo


            if (listaJugadas.Count > 4)  //para verificar que la lista contenga al menos 5 jugadores agregados
            {
                var primeros5 = objJuegoList.Take(5);  //selecciona los primeros 5 de la lista

                List<Juego> listaPrimeros5 = primeros5.ToList();
                listaPrimeros5.ForEach(i => Console.WriteLine("Jugador: {0},   Tiempo: {1} ", i.NombreJugador, i.tiempoTot));
                Console.WriteLine();            //los muestra 
            }
            else  //si hay menos que 5 los muestra igual de menor a mayor tiempo
            {
                objJuegoList.ForEach(i => Console.WriteLine("Jugador: {0},   Tiempo: {1} ", i.NombreJugador, i.tiempoTot));
                Console.WriteLine();
            }

        }

        public void Intentos()
        {
            Console.Write("Ingrese cantidad de intentos: ");
            maximaFallo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        
    }
}
