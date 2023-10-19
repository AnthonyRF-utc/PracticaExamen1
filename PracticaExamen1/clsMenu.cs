using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class clsMenu
    {
        //Atributo
       static int opcion = 0;


        public static void Desplegar()
        {
            do
            {
                Console.WriteLine("1- Inicializar");
                Console.WriteLine("2- Incluir estudiantes");
                Console.WriteLine("3- Modificar");
                Console.WriteLine("4- Consultar");
                Console.WriteLine("5- Reporte");
                Console.WriteLine("6- Borrar");
                Console.WriteLine("7- Salir");
                //opcion = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:clsEstudiante.inicializar(); break;
                    case 2:clsEstudiante.Agregar(); break;
                    case 3:clsEstudiante.modificar(clsEstudiante.solicitacedula()); break;
                    case 4: clsEstudiante.Consultar(clsEstudiante.solicitacedula()); break;
                    case 5:
                        Console.Clear(); Submenu();  break;
                    case 6: clsEstudiante.Borrar(); break;
                    case 7: break;
                    default:
                        break;
                }

            } while (opcion!=5);
        }

        public static void Submenu()
        {
            do
            {
                Console.WriteLine("1- Reporte estudiante por condicion");
                Console.WriteLine("2- Reporte general");
                Console.WriteLine("3- Salir");
                //opcion = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: Console.WriteLine("Reporte 1"); break;
                    case 2: Console.WriteLine("Reporte 2"); break;
                    case 3:  break;
                    default:
                        break;
                }

            } while (opcion != 3);
        }

    }
}
