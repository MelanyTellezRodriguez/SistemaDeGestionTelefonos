using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionTelefonos
{
    internal class TelefonoBasico : Telefono
    {

        //Atributos de la clase TelefonoBasico la cual hereda atributos de la clase Telefono.
        public bool TieneRadioFM {  get; set; }
        public bool TieneLinterna { get; set; }


        //Metodo para pedir los datos especificos del telefono basico.
        public void PedirDatosTelefonoBasico()
        {
            //Mandamos a llamar al metodo que se encuentra en la clase padre Telefono
            PedirDatosTelefono();

            Console.WriteLine("¿Tiene radio Fm?, si la respuesta es si, escriba (true); si la respuesta es no, escriba (false)");
            this.TieneRadioFM = bool.Parse(Console.ReadLine());

            Console.WriteLine("¿Tiene linterna, si la respuesta es si, escriba (true); si la respuesta es no, escriba (false)");
            this.TieneLinterna = bool.Parse(Console.ReadLine());
        }

        //Metodo para mostrar la informacion que el usuario ingresó 
        public void MostrarInformacionBasico()
        {
            //mandamos a llamar al metodo MostrarInformacion del la clase padre Telefono.
            MostrarInformacion();

            //Al igual mostramos la informacion especifica del telefono basico

            Console.WriteLine($"Tiene radio Fm: {TieneRadioFM}, Tiene Linterna: {TieneLinterna}");
            Console.WriteLine(".............................................................");
            Console.WriteLine("");
        }
    }
}
