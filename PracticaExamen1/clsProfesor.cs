using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class clsProfesor
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }

        //metodo

        public void Agregar()
        {
            clsMenu.Desplegar();
            Console.Read();
        }

        public void Borrar()
        {

        }

        public void Consultar()
        {

        }
    }
}
