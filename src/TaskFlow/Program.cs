using System;
using TaskFlow.Services;
using TaskFlow.Utils;

namespace TaskFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos el servicio de tareas
            TaskService taskService = new TaskService();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== TaskFlow - Gestión de Tareas ===");
                Console.WriteLine("1. Crear tarea");
                Console.WriteLine("2. Listar tareas"); 
                Console.WriteLine("3. Actualizar estado"); 
                Console.WriteLine("4. Cambiar responsable");
                Console.WriteLine("5. Eliminar tarea");
                Console.WriteLine("6. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("--- CREAR NUEVA TAREA ---");
                        // Usamos el ConsoleHelper para pedir los datos
                        string titulo = ConsoleHelper.PedirTextoObligatorio("Título (obligatorio): ");
                        string descripcion = ConsoleHelper.PedirTextoOpcional("Descripción (opcional): ");
                        string responsable = ConsoleHelper.PedirTextoOpcional("Responsable: ");

                        // Llamamos al método que creaste recién
                        taskService.CreateTask(titulo, descripcion, responsable);

                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "6":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}