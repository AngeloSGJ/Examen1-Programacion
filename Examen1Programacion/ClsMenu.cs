using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Programacion
{
    internal class ClsMenu
    {
        static int opcion = 0;

        public static void desplegar()  //si no se pone public es privado, entonces no se usa donde queramos
        {
            Console.Clear();
            do
            {
                Console.WriteLine("1- Inicializar datos");
                Console.Clear();
                Console.WriteLine("1- Inicializar datos");
                Console.WriteLine("2- Agregar empleados");
                Console.WriteLine("3- Modificar los datos de los empleados empleados");
                Console.WriteLine("4- Borrar empleados");
                Console.WriteLine("5- Reportes de los datos de los empleados");
                Console.WriteLine("6- Salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: ClsEmpleado.inicializar(); break;
                    case 2: ClsEmpleado.agregar(); break;
                    case 3: ClsEmpleado.modificar(ClsEmpleado.solicitacedula()); break;
                    case 4: ClsEmpleado.borrar(); break;
                    case 5:
                        Console.Clear(); submenu(); break;
                    case 6: break;
                    default:
                        break;
                }

            } while (opcion != 6);
        }
        public static void submenu()
        {
            do
            {
                Console.WriteLine("1- Consultar empleados");
                Console.WriteLine("2- Lista de los empleados");
                Console.WriteLine("3- Promedio de los salarios");
                Console.WriteLine("4- Comparacion entre los salarios");
                Console.WriteLine("5- Salir al menu principal");
                int.TryParse(Console.ReadLine(), out opcion); 
                switch (opcion)
                {
                    case 1: ClsEmpleado.consultar(ClsEmpleado.solicitacedula()); break;
                    case 2: ClsEmpleado.Listaempleados(); break;
                    case 3: ClsEmpleado.promediosalarios(); break;
                    case 4: ClsEmpleado.comparasalario(); break;
                    case 5: break;
                    default:
                        break;
                        
                }

            } while (opcion != 5);
            Console.Clear();
        }
    }
}
    
