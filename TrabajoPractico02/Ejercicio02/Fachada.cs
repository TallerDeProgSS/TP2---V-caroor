using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Fachada
    {
        private RepositorioBanca objRepositorio = new RepositorioBanca();
        

        // Menu

                                     /////////////////////////////////////    CUENTAS  /////////////////////////////////////

        public void CrearCuenta(string pNumero, string pTitular)                //para crear una nueva cuenta
        {
            Banca objBanca = new Banca(pNumero, pTitular);          //crea una nueva banca ingresando el numero y titular que se ingresó previamente
             
            //crea la parte de cuenta unificada
            objBanca.EnPesos = new Cuenta(new Moneda("ARS", "Peso Argentino", "$"));  //CodigoISO, nombre y simbolo del dolar
            objBanca.EnDolares = new Cuenta(new Moneda("USD", "Dolar", "$"));      //CodigoISO, nombre y simbolo del dolar

            objRepositorio.Agregar(objBanca);

        }

        public bool CuentasExistentes(string pNumero)               //se requiere el numero de cuenta  (documento)
        {                                                           //cuando se realiza acredita o debita sobre la cuenta, 
                                                                    //verifica previamente que esta exista
            bool cuentaExiste = false;      //bool para verificar si existe la cuenta o no


            if (objRepositorio.Obtener(pNumero) != null)        //obtiene el numero de cuenta y verifica si es distinto de null
            {
                cuentaExiste = true;        // si es distinto a null, entonces devuelve true, ya que existe la cuenta
            }
            
            return cuentaExiste;  // si no cumple, devuelve falto
            
        }



                                    /////////////////////////////////////    SECCIÓN EN DOLARES    /////////////////////////////////////

        //Acreditar saldo
        public void AcreditarSaldoDOLARES(double cant, string pNumero)              
        {
            Banca objBanca = (objRepositorio.Obtener(pNumero));     // verifica si existe la cuenta

                objBanca.EnDolares.AcreditarSaldo(cant);    //hace la acreditación sobre la cuenta en dolares

                Console.WriteLine("Saldo: $" + objBanca.EnDolares.Saldo);   //muestra el saldo total
                Console.WriteLine();
            
        }


        //Debitar saldo

        public void DebitarSaldoDOLARES(double cant, string pNumero)
        {
            Banca objBanca = (objRepositorio.Obtener(pNumero));     // verifica si existe la cuenta
                        
                objBanca.EnDolares.DebitarSaldo(cant); //debita sobre la cuenta en dolares

                Console.WriteLine("Saldo: $" + objBanca.EnDolares.Saldo);   //muestra el saldo total
                Console.WriteLine();
            
        }



                                     /////////////////////////////////////    SECCIÓN EN PESOS   /////////////////////////////////////

        //Acreditar saldo
        public void AcreditarSaldoPESOS(double cant, string pNumero)
        {
            Banca objBanca = (objRepositorio.Obtener(pNumero));  // busca la cuenta existente
            
                objBanca.EnPesos.AcreditarSaldo(cant);  //acredita en pesos

                Console.WriteLine("Saldo: $" + objBanca.EnPesos.Saldo);   //muestra el saldo
                Console.WriteLine();
            

        }



        //Debitar saldo

        public void DebitarSaldoPESOS(double cant, string pNumero)
        {
            Banca objBanca = (objRepositorio.Obtener(pNumero));    // busca la cuenta existente

            objBanca.EnPesos.DebitarSaldo(cant);

        }


                                     /////////////////////////////////////   MOSTRAR SALDO    /////////////////////////////////////

        public void MostrarSaldo(string pNumero)
        {
            Banca objBanca = (objRepositorio.Obtener(pNumero));
            Console.WriteLine("El saldo en pesos es: $" + objBanca.EnPesos.Saldo);        //muestra el saldo en pesos
            Console.WriteLine("El saldo en dolares es : $" + objBanca.EnDolares.Saldo);  //muestra el saldo en dolares

            Console.WriteLine();
        }


    }
}
