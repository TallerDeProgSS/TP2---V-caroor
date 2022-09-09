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
        int totalCuentas = 5;           //variable con el límite de cuentas, para que se pueda comparar con la cantidad de cuentas registradas
        int cantCuentas = 0; //contador

      public Banca Obtener(string pNumero)              //para obtener la cuenta a partir del dni
        {
            Banca CuentaPer = null;     

            for (int i = 0; i < cantCuentas; i++)       //verifica en cada cuenta
            {
                if (array[i].Numero == pNumero)     //si alguna cuenta es igual a pNumero
                {
                    CuentaPer = array[i];       //devuelve la cuenta registrada
                }
            }   
            return CuentaPer;       //en caso de que no exista la cuenta, devuelve null
        }

        public void Agregar(Banca pBanca)           //para agregar una cuenta
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
