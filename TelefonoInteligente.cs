using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionTelefonos
{

    //Clase TelefonoInteligente la cual hereda atributos de la clase Telefono
    internal class TelefonoInteligente : Telefono
    {
        //Atributos especificos de la clase TelefonoInteligente
        public string SistemaOperativo { get; set; }
        public int MemoriaRam {  get; set; }


        //Metodo para pedir los datos especificos del Telefono inteligente 
        public void PedirDatosTelefonoInteligente()
        {
            //Mandamos a llamar al metodo que se encuentra en la clase padre Telefono
            PedirDatosTelefono();

            
            try
            {
                Console.WriteLine("Ingrese el sistema operativo del telefono inteligente:");
                this.SistemaOperativo = Console.ReadLine();

            }catch(Exception )
            {
                Console.WriteLine("Dato no valido");

            }
            do
            {
                try
                {
                    Console.WriteLine("Ingrese la memoria Ram del telefono inteligente:");
                    this.MemoriaRam = Convert.ToInt32(Console.ReadLine());

                }catch(Exception)
                {
                    Console.WriteLine("Error!! Dato no valido");
                }
               
            } while (MemoriaRam <= 0);
        }


        //Metodo para mostrar la informacion del telefono inteligente
        public void MostrarInformacionInteligente()
        {
            //Mandamos a llamar al metodo que se encuentra en la clase padre Telefono la cual contiene los datos
            //generales de los telefonos 
            MostrarInformacion();
            
            //Al igual mostramos los datos especificos del telefono inteligente
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, Memoria Ram: {MemoriaRam} GB");
            Console.WriteLine(".............................................................");
            Console.WriteLine("");

        }
    }
}
