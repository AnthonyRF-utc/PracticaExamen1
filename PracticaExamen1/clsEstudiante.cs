using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class clsEstudiante
    {
        // atributos
        static int cantidad = 2;
        static  public string[] cedula = new string[cantidad];  //blancos
        static public string[]nombre = new string[cantidad];   //blancos
        static public int[] nota = new int[cantidad];          // 0

        //metodos
        static public void inicializar()
        {
           
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            nota = Enumerable.Range(1, cantidad).ToArray();
            Console.WriteLine("El sistema ha sido inicializado");


        }

        public static void Agregar()
        {
            Console.Clear();
            int contador = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite la cedula {0}: ",contador);
                cedula[i] = Console.ReadLine();
                Console.WriteLine("Digite el nombre {0}: ",contador);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Digite la nota {0}: ",contador);
                int.TryParse(Console.ReadLine(), out nota[i]);
                contador++;
                Console.Clear();
            }
        }

       public static string solicitacedula()
        {
            Console.WriteLine("Digite la cedula");
            string ced = Console.ReadLine();
            return ced;
        }

        static public void modificar(string ced)
        {
      
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[1]))
                {
                    Console.WriteLine("Digite el nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite la nota: ");
                    int.TryParse(Console.ReadLine(), out nota[i]);
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Estudiante no existe");
            }
        }
        public static void Consultar(string ced)
        {
           
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[1]))
                {
                    Console.WriteLine($"Nombre: {nombre[i]} y la nota: {nota[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Estudiante no existe");
            }
        }

        public static void Borrar()
        {
            Console.WriteLine("Digite la cedula:");
            string ced = Console.ReadLine();
            bool borrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[0]))
                {
                    Console.WriteLine("Digite el nombre: ");
                    nombre[0] = Console.ReadLine();
                    Console.WriteLine("Digite la nota: ");
                    int.TryParse(Console.ReadLine(), out nota[0]);
                    borrado = true;
                    break;
                }
            }
        }

    }
}
