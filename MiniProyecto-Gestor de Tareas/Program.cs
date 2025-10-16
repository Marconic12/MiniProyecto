using System;
using System.Collections.Generic;

namespace GestorTareasFuncional
{
    internal class Program
    {
        static List<string> descripciones = new List<string>();
        static List<DateTime> fechas = new List<DateTime>();
        static List<bool> completadas = new List<bool>();

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== GESTOR DE TAREAS =====");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Completar tarea");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                // Validación de entrada
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarTarea();
                        break;
                    case 2:
                        ListarTareas();
                        break;
                    case 3:
                        CompletarTarea();
                        break;
                    case 4:
                        EliminarTarea();
                        break;
                    case 0:
                        Console.WriteLine(" Saliendo del gestor...");
                        break;
                    default:
                        Console.WriteLine(" Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.ReadKey();

            } while (opcion != 0);
        }

        
    }
}
