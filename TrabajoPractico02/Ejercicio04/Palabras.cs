using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Palabras
    {
        
        public string palabrasRandom()
        {
            string[] palabras = { "hola", "perro", "casa", "telefono", "computadora", "transportador", "argentina", "helicoptero", "helado", "numeros", "renglones" };
            Random objRan = new Random();

            int numeroRandom = objRan.Next(0, 11); //seleciona una palabra entre 0 y la cantidad de palabras

            return palabras[numeroRandom]; //devuelve la palabra seleccionada
        }


        public string palabraOculta(string palabra)
        {
            string pPalabra = palabra;
            string pOculto = "";

            for (int i = 0; i < pPalabra.Length; i++)       //espacio oculto del mismo tamaño que la palabra seleccionada
            {
                pOculto += "_";       //a cada letra se la reemplaza por " _ "
            }

            return pOculto;
        }

       


    }
}

