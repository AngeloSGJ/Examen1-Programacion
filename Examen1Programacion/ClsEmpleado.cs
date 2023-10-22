using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Programacion
{
    internal class ClsEmpleado
    {
        static int cantidad = 1;
        static public string[] cedula = new string[cantidad];
        static public string[] nombre = new string[cantidad];
        static public string[] direccion = new string[cantidad];
        static public int[] telefono = new int[cantidad];
        static public float[] salario = new float[cantidad];

        public static void agregar()
        {
            int cont = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite la cedula {0} :   ", cont);
                cedula[i] = Console.ReadLine();
                Console.WriteLine("Digite el nombre {0} :   ", cont);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Digite la direccion {0} :   ", cont);
                direccion[i] = Console.ReadLine();
                Console.WriteLine("Digite el numero de telefono {0} :   ", cont);
                int.TryParse(Console.ReadLine(), out telefono[i]);
                Console.WriteLine("Digite el salario del empleado {0} :   ", cont);
                float.TryParse(Console.ReadLine(), out salario[i]);
                cont++;
            }
        }
        static public string solicitacedula()
        {
            Console.WriteLine("Digite la cedula");
            string ced = Console.ReadLine();
            return ced;



        }
        static public void consultar(string ced)
        {
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine($"Nombre : {nombre[i]} , Direccion:  {direccion[i]} , Telefono :  {telefono[i]} , Salario : {telefono[i]}");
                    encontrado = true;
                    break;
                }

                if (!encontrado)
                {
                    Console.WriteLine("Empleado no existe o ha sido borrado del sistema", "\n");
                }
            }
        }
        static public void modificar(string ced)
        {
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine("Modificador de datos de empleados");
                    Console.WriteLine("Digite el nombre");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite la direccion");
                    direccion[i] = Console.ReadLine();
                    Console.WriteLine("Digite el numero de telefono");
                    int.TryParse(Console.ReadLine(), out telefono[i]);
                    Console.WriteLine("Digite el salario del empleado");
                    float.TryParse(Console.ReadLine(), out salario[i]);
                    encontrado = true;
                    Console.WriteLine("Estudiante Modificado");
                    break;
                }

            }
        }
         static public void borrar()
        {
            Console.WriteLine("Digite la cedula");
            string ced = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    cedula = Enumerable.Repeat("", cantidad).ToArray();
                    nombre = Enumerable.Repeat("", cantidad).ToArray();   
                    direccion = Enumerable.Repeat("", cantidad).ToArray();
                    telefono = Enumerable.Repeat(0, cantidad).ToArray();
                    salario = Enumerable.Repeat(0f, cantidad).ToArray();
                    encontrado = true;
                    Console.WriteLine("Estudiante borrado del sistema", "\n");
                }
            }
        }
        static public void inicializar()
        {
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("", cantidad).ToArray();
            telefono = Enumerable.Repeat(0, cantidad).ToArray();
            salario = Enumerable.Repeat(0f, cantidad).ToArray();
        }
        static public void Listaempleados()
        {
            Array.Sort(nombre);

            Console.WriteLine("Lista de empleados: ", "\n");
            foreach (string nombres in nombre)
            {
                if (!string.IsNullOrEmpty(nombres)) 
                {
                    Console.WriteLine(nombres);
                }
            }
        }
        static public void promediosalarios()
        {
            float totalSalario = 0;

            for (int i = 0; i < cantidad; i++)
            {
                totalSalario += salario[i];
            }

            if (cantidad > 0)
            {
                float promedio = totalSalario / cantidad;
                Console.WriteLine($"El promedio del salario de los empleados es de: {promedio}", "\n");
            }
        }
        static public void comparasalario()
        {

            if (cantidad > 0)
            {
                float maximo = salario.Max();
                float minimo = salario.Min();
                Console.WriteLine("Los siguientes salarios son de los empleados con el salario mas alto y bajo respectivamente.");
                Console.WriteLine("El salario más alto es: " + maximo);
                Console.WriteLine("El salario más bajo es: " + minimo , "\n");
            }
        }





    }
}

