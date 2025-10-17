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
                Console.WriteLine("5. Salir");
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
                    case 5:
                        Console.WriteLine(" Saliendo del gestor...");
                        break;
                    default:
                        Console.WriteLine(" Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.ReadKey();

            } while (opcion != 5);
        }

        static void AgregarTarea()
        {
            Console.Clear();
            Console.WriteLine("=== AGREGAR TAREA ===");

            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();

            Console.Write("Fecha de vencimiento (yyyy-mm-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
            {
                Console.WriteLine(" Fecha inválida. No se agregó la tarea.");
                return;
            }

            descripciones.Add(descripcion);
            fechas.Add(fecha);
            completadas.Add(false);

            Console.WriteLine(" Tarea agregada correctamente.");
        }

        static void ListarTareas()
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE TAREAS ===");

            if (descripciones.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas.");
                return;
            }

            for (int i = 0; i < descripciones.Count; i++)
            {
                string estado = completadas[i] ? "✅ Completada" : "Pendiente";
                Console.WriteLine($"{i + 1}. {descripciones[i]} - Vence: {fechas[i]:yyyy-MM-dd} - {estado}");
            }
        }
        static void EliminarTarea()
        {
            ListarTareas();

            if (descripciones.Count == 0)
            {
                return;
            }
            Console.Write("\nIngrese el número de la tarea a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= descripciones.Count)
            {
                descripciones.RemoveAt(num - 1);
                fechas.RemoveAt(num - 1);
                completadas.RemoveAt(num - 1);
                Console.WriteLine(" Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine(" Número de tarea no válido.");
            }
        }
    }
}
        
    

    

            } while (opcion != 0);
        }

        static void CompletarTarea()
        {
            ListarTareas();

            if (descripciones.Count == 0) return;

            Console.Write("\nIngrese el número de la tarea a completar: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= descripciones.Count)
            {
                completadas[num - 1] = true;
                Console.WriteLine("✅ Tarea marcada como completada.");
            }
            else
            {
                Console.WriteLine("⚠️ Número de tarea no válido.");
            }
        }

    }
}
