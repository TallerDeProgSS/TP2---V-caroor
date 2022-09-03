using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Cuenta
    {


        private double iSaldo;
        private Moneda iMoneda;


        public Cuenta(Moneda pMoneda)
        {
            iSaldo += 0;         //primer constructor, establece la moneda inicializando el saldo en cero.
            iMoneda = pMoneda;  
        }
        

        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;        //asigna el saldo de la cuenta con su correspondiente moneda.
            this.iMoneda = pMoneda;             //asigna la moneda que se utilizará para realizar movimientos o consultas
        }
        
        public double Saldo         //obtiene el saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }

        public void AcreditarSaldo(double pSaldo)       //Acreditar el saldo ingresado
        {
            this.iSaldo += pSaldo;  //agrega el saldo ingresado a la cuenta
            Console.WriteLine("Acreditado con exito");      //muestra en consola el mensaje
        }

        public bool DebitarSaldo(double pSaldo)         //debitar el saldo ingresado
        {
            //verifica las condiciones de saldo
            if (pSaldo > this.iSaldo)           //comprueba si el saldo ingresado es mayor que el saldo de la cuenta
            {
                Console.WriteLine("El monto ingresado es insuficiente");       //si es mayor muestra que no se puede hacer dicha operacion 
                return false;  //si el saldo que se quiere debitar es mayor que el saldo disponible, devuelve falso
            }
            else    // si el saldo que se quiere debitar es menor que el saldo disponible, acepta.
            {
                this.iSaldo -= pSaldo; //descuenta el saldo de la cuenta 
                Console.WriteLine("Debitado con exito");        //muestra por consola que se realizó con exito
                return true;        //devuelve true a la operacion
            }
        }

    }
}
