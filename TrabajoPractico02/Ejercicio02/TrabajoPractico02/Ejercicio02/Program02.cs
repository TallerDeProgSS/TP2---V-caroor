using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class prueba
    {
        static void Main(string[] args)
        {
            int opcion;
            int num;
            int opcion2;
            Fachada objFachada = new Fachada();  //Banca objCuenta = new Banca();    //se crea primero para que "guarde" la información
            do 
            { 

                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Ingresar cuenta");
                Console.Write("Ingrese un número: ");
                opcion2 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            //do
            //{ 
                switch (opcion2)
                {
                    case 1:
                        {
                            
                                Console.Write("Ingrese Titular: ");
                                var titular = Console.ReadLine();

                                Console.Write("Ingrese documento: ");
                                var documento = Console.ReadLine();

                            //verifica si ya existe una cuenta

                            if (objFachada.CuentasExistentes(documento) != true) //si es distinto a true, entonces NO existe la cuenta
                            {                                                       // y crea al nuevo usuario
                                //Registra al nuevo usuario
                                objFachada.CrearCuenta(documento, titular);
                                Console.WriteLine("Registrado con éxito");
                                Console.Write("Ingrese 1 para volver a ingresar y comenzar a operar en su cuenta: "); //NO FUNCIONA
                                num = Convert.ToInt32(Console.ReadLine());


                                Console.Clear();
                                //toda la pantalla
                            }
                            else                                        //si es igual a true, entonces documento ya existe.
                            {
                                Console.Write("Ya existe la cuenta, ingrese 1 para ingresar a su cuenta: ");
                                num = Convert.ToInt32(Console.ReadLine());

                                Console.Clear();

                            }
                                
                                                            
                        }
                        break;

                    case 2:
                        {                            
                            Console.Write("Ingrese documento: ");
                            var documento = Console.ReadLine();

                            if (objFachada.CuentasExistentes(documento) != false) //si es distinto a false, entonces EXISTE la cuenta y puede operar en ella
                            {                                                       
                                Console.Clear();

                                do
                                {

                                    Console.WriteLine("1. Operar sobre cuenta en dolares");
                                    Console.WriteLine("2. Operar sobre cuenta en pesos");
                                    Console.WriteLine("3. Volver atrás");
                                    Console.Write("Ingrese un numero: ");       //seleccionar sobre que cuenta desea operar
                                    num = Convert.ToInt32(Console.ReadLine());

                                    Console.Clear();

                                    switch (num)         //dependiendo la opción que se enumere tendrá un nuevo menu seleccionable
                                    {
                                        case 1:
                                            {
                                                do            // OPERACIONES SOBRE CUENTA EN DOLARES
                                                {
                                                    Console.WriteLine(" EN DOLARES ");
                                                    Console.WriteLine("1. Acreditar saldo");
                                                    Console.WriteLine("2. Debitar saldo");
                                                    Console.WriteLine("3. Mostrar saldo");
                                                    Console.WriteLine("4. Volver atrás");
                                                    Console.Write("Ingrese un numero: ");       //seleccionar que desea hacer
                                                    opcion = Convert.ToInt32(Console.ReadLine());


                                                    Console.Clear();

                                                    switch (opcion)
                                                    {
                                                        case 1:
                                                            {
                                                                Console.Clear();

                                                                Console.Write("Ingrese el monto a acreditar: ");    //solicita el saldo que desea ingresar a la cuenta
                                                                double cantidad = Convert.ToDouble(Console.ReadLine());

                                                                objFachada.AcreditarSaldoDOLARES(cantidad, documento);  //Acredita en dolares

                                                            }
                                                            break;

                                                        case 2:
                                                            {
                                                                Console.Clear();

                                                                Console.Write("Ingrese el mondo a debitar: ");      //solicita el saldo que desea extraer de la cuenta
                                                                double cantidad = Convert.ToDouble(Console.ReadLine());

                                                                objFachada.DebitarSaldoDOLARES(cantidad, documento);    //debita el dolares

                                                            }
                                                            break;
                                                        case 3:
                                                            {
                                                                Console.Clear();
                                                                objFachada.MostrarSaldo(documento);

                                                            }
                                                            break;

                                                        case 4:
                                                            {
                                                                //vacío para volver a la pantalla anterior
                                                            }
                                                            break;
                                                    }

                                                } while (opcion != 4);
                                            }
                                            break;

                                        case 2:          // OPERACIONES SOBRE CUENTA EN PESOS
                                            {
                                                do
                                                {
                                                    Console.WriteLine(" EN PESOS ");
                                                    Console.WriteLine("1. Acreditar saldo");
                                                    Console.WriteLine("2. Debitar saldo");
                                                    Console.WriteLine("3. Mostrar saldo");
                                                    Console.WriteLine("4. Volver atrás");
                                                    Console.Write("Ingrese un numero: ");       //seleccionar que desea hacer
                                                    opcion = Convert.ToInt32(Console.ReadLine());

                                                    Console.Clear();

                                                    switch (opcion)
                                                    {
                                                        case 1:
                                                            {
                                                                Console.Clear();

                                                                Console.Write("Ingrese el monto a acreditar: ");    //solicita el saldo que desea ingresar a la cuenta
                                                                double cantidad = Convert.ToDouble(Console.ReadLine());

                                                                objFachada.AcreditarSaldoPESOS(cantidad,documento);     //acredita el saldo

                                                            }
                                                            break;

                                                        case 2:
                                                            {
                                                                Console.Clear();

                                                                Console.Write("Ingrese el mondo a debitar: ");      //solicita el saldo que desea extraer de la cuenta
                                                                double cantidad = Convert.ToDouble(Console.ReadLine());

                                                                objFachada.DebitarSaldoPESOS(cantidad, documento);   //Debita en pesos

                                                            }
                                                            break;
                                                        case 3:
                                                            {
                                                                Console.Clear();
                                                                objFachada.MostrarSaldo(documento);
                                                            }
                                                            break;

                                                        case 4:
                                                            {
                                                                //vacío para volver a la pantalla anterior
                                                            }
                                                            break;
                                                    }

                                                } while (opcion != 4);      //el bucle sigue hasta que se selecciona la opción 4
                                            }
                                            break;

                                        case 3:
                                            {

                                            }
                                            break;
                                    }
                                } while (num != 3);  //el bucle sigue hasta que se selecciona la opción 3

                             }

                            else
                            {
                                Console.WriteLine("No se encontró la cuenta");
                                Console.WriteLine();
                            }

                        }
                        break;
                }
            } while (opcion2 != 3);
        }
    }
}
