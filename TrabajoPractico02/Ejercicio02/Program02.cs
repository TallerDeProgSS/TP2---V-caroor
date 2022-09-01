using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program02 //menu principal
    {
        static void Main(string[] args)
        {
            int opcion;
            int num;
            Banca objCuenta = new Banca();      //se crea primero para que "guarde" la información

            do
            {
                
                Console.WriteLine("1. Operar sobre cuenta en dolares");
                Console.WriteLine("2. Operar sobre cuenta en pesos");
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

                                switch(opcion)
                                {
                                    case 1:
                                        {
                                            Console.Clear();

                                            Console.Write("Ingrese el monto a acreditar: ");    //solicita el saldo que desea ingresar a la cuenta
                                            double cantidad = Convert.ToDouble(Console.ReadLine());
                                                                                        
                                            objCuenta.EnDolares.AcreditarSaldo(cantidad);  //Acredita en dolares

                                            Console.WriteLine("Saldo: $" + objCuenta.EnDolares.Saldo);   //muestra el saldo
                                            Console.WriteLine();
                                        }
                                        break;

                                    case 2:
                                        {
                                            Console.Clear();

                                            Console.Write("Ingrese el mondo a debitar: ");      //solicita el saldo que desea extraer de la cuenta
                                            double cantidad = Convert.ToDouble(Console.ReadLine());

                                            objCuenta.EnDolares.DebitarSaldo(cantidad);     //debita el dolares

                                            Console.WriteLine();      
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.Clear();
                                                                                        
                                            Console.WriteLine("El saldo en pesos es: $" + objCuenta.EnPesos.Saldo );        //muestra el saldo en pesos
                                            Console.WriteLine("El saldo en dolares es : $" + objCuenta.EnDolares.Saldo ) ;  //muestra el saldo en dolares

                                            Console.WriteLine();
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
 
                                            objCuenta.EnPesos.AcreditarSaldo(cantidad);     //acredita el saldo

                                            Console.WriteLine("Saldo: $" + objCuenta.EnPesos.Saldo);   //muestra el saldo
                                            Console.WriteLine();


                                        }
                                        break;

                                    case 2:
                                        {
                                            Console.Clear();

                                            Console.Write("Ingrese el mondo a debitar: ");      //solicita el saldo que desea extraer de la cuenta
                                            double cantidad = Convert.ToDouble(Console.ReadLine());
                                                                                       
                                            objCuenta.EnPesos.DebitarSaldo(cantidad);   //Debita 

                                            Console.WriteLine();

                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.Clear();
                                           
                                            Console.WriteLine("El saldo en pesos es: $" + objCuenta.EnPesos.Saldo);         //muestra el saldo en pesos
                                            Console.WriteLine("El saldo en dolares es : $" + objCuenta.EnDolares.Saldo);    //muestra el saldo en dolares

                                            Console.WriteLine();
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
    }
}
