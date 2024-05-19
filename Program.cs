using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace SistemaDeGestionTelefonos
{

    internal class Program
    {
        //Declaracion y creacion de un nuevo arreglo de TelefonoInteligente y TelefonoBasico, con espacion
        //para cinco elementos.

        TelefonoInteligente[] registrarInteligente = new TelefonoInteligente[5];
        TelefonoBasico[] registrarBasico = new TelefonoBasico[5];
        int contador = 0;


        static void Main(string[] args)
        {
            //declaramos una variable llamada telefono de tipo Telefono, asignamos a la variable telefono una nueva
            //instancia de la clase Telefono, la palabra new se utiliza para crear un nuevo objeto.

            Telefono telefono = new Telefono();
            TelefonoInteligente inteligente = new TelefonoInteligente();
            TelefonoBasico Basico = new TelefonoBasico();

            Program prog = new Program();



            int opcion = 0;
            int intentos = 0;

            //Mostramos el Menu, validado con do while y try catch.
            do
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("SISTEMA PARA GESTIONAR EL INVENTARIO DE UNA TIENDA DE TELEFONOS");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("::::                 OPCIONES                     ::::");
                Console.WriteLine("......................................................");
                Console.WriteLine("::::      1. Registrar telefono                   ::::");
                Console.WriteLine("::::      2. Mostrar Telefonos Registrados        ::::");
                Console.WriteLine("::::      3. Consultar Stock de un telefono       ::::");
                Console.WriteLine("::::      4. Salir                                ::::");
                Console.WriteLine("......................................................");

                while (intentos < 3)
                {
                    try
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione una opcion:");
                        opcion = Convert.ToInt32(Console.ReadLine());
                       
                        if (opcion > 0 && opcion <= 4)
                        {
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            throw new Exception("Numero no valido");

                        }

                    }

                    catch (Exception)
                    {
                        intentos++;
                        Console.WriteLine("Error!! debe ingresar un numero entero que lo encuentre entre las opciones");

                    }

                    if (intentos == 3)
                    {
                        Console.WriteLine("La cantidad de intentos se han agotado");
                        return;

                    }

                }

                switch (opcion)
                {


                    case 1:


                        prog.RegistrarTelefonos();

                        break;

                    case 2:
                        prog.MostrarTelefonosRegistrados();



                        break;

                    case 3:

                        prog.ConsultarStockDelTelefono();

                        break;

                    case 4:
                        Console.WriteLine("--Saliendo del sistema--");
                        break;

                    default:
                        Console.WriteLine("La opcion que ha ingresado no esvalida");
                        break;

                }

            } while (opcion != 4);

        }

        //Metodo para registrar los telefonos, ya sea que el usuario ingrese que quiere registrar untelefono
        //inteligente o un telefono basico
        public void RegistrarTelefonos()
        {
          
               
                    string tipoTelefono;
                    Console.WriteLine("¿Qué tipo de telefono desea registrar?");
                    Console.WriteLine("-->  Si desea registrar un telefono inteligente escriba (Inteligente)");
                    Console.WriteLine("-->  Si desea registrar un telefono basico escriba (Basico)");
                    tipoTelefono = Console.ReadLine();
                    Console.WriteLine("");


                   //Comprueba si tipoTelefono es igual a la cadena "Inteligente"
                    if (tipoTelefono == "Inteligente")
                    {
                        //comprueba que i sea mayor al tamaño del arreglo, incrementando i en cada una de las
                        //iteraciones, dentro de este bloque for se puede acceder a cada uno de los elementos
                        //del arreglo usando el indice i.
                        for (int i = 0; i < registrarInteligente.Length; i++)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine("Telefono" + "  " + (1 + i));
                            Console.WriteLine("-------------------------");

                           //creacion de un nuevo telefono
                            registrarInteligente[i] = new TelefonoInteligente();
                            contador++;
                            registrarInteligente[i].PedirDatosTelefonoInteligente();
                            Console.WriteLine("");
                            Console.WriteLine("¡TELEFONO REGISTRADO EXITOSAMENTE!");
                            Console.WriteLine("");

                        }

                    }
                    else if (tipoTelefono == "Basico")
                    {
                        for (int i = 0; i < registrarBasico.Length; i++)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine("Telefono" + "  " + (1 + i));
                            Console.WriteLine("-------------------------");

                            registrarBasico[i] = new TelefonoBasico();
                    
                            registrarBasico[i].PedirDatosTelefonoBasico();
                            Console.WriteLine("");
                            Console.WriteLine("¡TELEFONO REGISTRADO EXITOSAMENTE!");
                            Console.WriteLine("");

                        }

                    }    

        }



        //Metodo para mostrar los Telefonos regsitrados
        public void MostrarTelefonosRegistrados()
        {
            if (contador == 0)
            {
                Console.WriteLine(" Error!!  No se encuentran telefonos registrados");
                Console.WriteLine("");

            }
            else
            {
                string tipoTelefono;
                Console.WriteLine("");
                Console.WriteLine("¿Qué tipo de telefono registró anteriormente?");
                Console.WriteLine("--> Si registró un telefono inteligente escriba (1)");
                Console.WriteLine("--> Si registró  un telefono basico escriba (2)");
                tipoTelefono = Console.ReadLine();

                if (tipoTelefono == "1")
                {
                    for (int i = 0; i < registrarInteligente.Length; i++)
                    {
                        //mandamos a llamar al metodo que se encuentra en la clase "TelefonoInteligente"
                        //del objeto del arreglo en la posicion i.
                        registrarInteligente[i].MostrarInformacionInteligente();
                    }

                }

                else if (tipoTelefono == "2")
                {
                    for (int i = 0; i < registrarBasico.Length; i++)
                    {
                        registrarBasico[i].MostrarInformacionBasico();
                    }
                }
                else
                {
                    Console.WriteLine("Error!! el tipo de telefono que ha ingresado no es valido");

                }

            }
        }

        //Metodo para consultar el Stock de un telefono en especifico
        public void ConsultarStockDelTelefono()
        {

            if (contador == 0)
            {
                Console.WriteLine(" Error!!  No se encuentran telefonos registrados");
                Console.WriteLine();

            }
            else
            {

                string tipoTelefono;
                Console.WriteLine("");
                Console.WriteLine("¿Qué tipo de telefono registró anteriormente?");
                Console.WriteLine("--> Si registró un telefono inteligente escriba (1)");
                Console.WriteLine("--> Se registró  un telefono basico escriba (2)");
                tipoTelefono = Console.ReadLine();
                Console.WriteLine("");

                if (tipoTelefono == "1")
                {
                    Console.WriteLine("Ingrese nuevamente el modelo del telefono:");
                    string modelo = Console.ReadLine();


                    for (int i = 0; i < registrarInteligente.Length; i++)
                    {
                        //accede a la posicion i de arreglo .
                        //accede a la propiedad Modelo del objeto que se encuentra en el arreglo
                        //registrarInteligente[i]
                        //compara si lo que hay en el atributo Modelo del objeto es igual a lo que 
                        //se le pide al usuario que ingrese lo cual es el modelo del telefono del cual
                        //quiere obtener el Stock

                        if (registrarInteligente[i].Modelo == modelo)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(":::El Stock del telefono es: " + registrarInteligente[i].Stock + ":::");
                            Console.WriteLine("");

                        }
                        //Si lo que ingrese el usuario es diferente a los modelo que han sido registrados 
                        //anteriormente. entonces ese tipo de modelo no se encuentra en el inventario
                        else if (registrarInteligente[i].Modelo != modelo)
                        {
                            Console.WriteLine("Este telefono no es encontrado en el inventario");
                        }
                    }

                }

                else if (tipoTelefono == "2")
                {
                    Console.WriteLine("Ingrese nuevamete el modelo del telefono:");
                    string modelo = Console.ReadLine();

                    for (int i = 0; i < registrarBasico.Length; i++)
                    {
                        if (registrarBasico[i].Modelo == modelo)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(":::El Stock del telefono es: " + registrarBasico[i].Stock + ":::");
                            Console.WriteLine("");
                        }

                        else if (registrarBasico[i].Modelo != modelo)
                        {
                            Console.WriteLine("Este telefono no es encontrado en el inventario");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Error!! El tipo de telefono que ha ingresado no es valido");
                }

            }

        }
    }
}
