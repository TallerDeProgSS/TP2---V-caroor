using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class RepositorioBanca
    {
        Banca[] array = new Banca[5]; //5 cuentas nuevas
        int totalCuentas = 5;
        int cantCuentas = 0; //contador

      public Banca Obtener(string pNumero)              //para obtener la cuenta a partir del dni
        {
            Banca CuentaPer = null;

            for (int i = 0; i < cantCuentas; i++)
            {
                if (array[i].Numero == pNumero)
                {
                    CuentaPer = array[i];
                }
            }   
            return CuentaPer;
        }

        public void Agregar(Banca pBanca)
        {
            if (cantCuentas < totalCuentas)     //si la cantidad de cuentas es menor que el total de las cuentas
            {
                array[cantCuentas] = pBanca;        //agrega al array otra cuenta más
                cantCuentas++;                      //suma el contador
            }
            else            //en caso que ya no haya capacidad
            {
                Console.Clear();
                Console.WriteLine("No se pueden agregar más cuentas");         //muestra el mensaje que no se puede agregar más cuentas
            }
        }



        
    }
}
