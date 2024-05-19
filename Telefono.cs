using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionTelefonos
{
    internal class Telefono
    {
        //Atributos de la clase telefono
        public string Marca {  get; set; }
        public string Modelo {  get; set; }
        public decimal Precio {  get; set; }
        public int Stock { get; set; }


        //Metodod para pedir los datos generales del telefono 
        public void PedirDatosTelefono()
        {
           
           Console.WriteLine("Ingrese la marca del telefono:");
           this.Marca = Console.ReadLine();
          
           Console.WriteLine("Ingrese el modelo del telefono:");
           this.Modelo = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el precio del telefono:");
                    this.Precio = Convert.ToDecimal(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Error!! dato no valido");
                }
              

            } while (Precio <= 0);
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el Stock del telefono:");
                    this.Stock = Convert.ToInt32(Console.ReadLine());

                    if(Stock == 0)
                    {
                        Console.WriteLine("**Fuera de Stock**");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Error!! dato no valido");

                }
                

            } while( Stock < 0);
      
        }

        //Metodo para mostrar la informacion de los datos que ingresó el usuario
        public void MostrarInformacion()
        { 
            
            Console.WriteLine("...........................................................");
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Precio: ${Precio}, Stock: ${Stock}");
        }
    }
}
