using System;

namespace TaskFlow.Utils
{
    public static class ConsoleHelper
    {
        // Método para pedir un texto y obligar a que no esté vacío (Ideal para el Título)
        public static string PedirTextoObligatorio(string mensaje)
        {
            string input;
            do
            {
                Console.Write(mensaje);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Este campo es obligatorio. Intente de nuevo.");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        // Método para pedir texto opcional (Ideal para la Descripción) (QUE OPINA MARTIN Y GONZALO)
        public static string PedirTextoOpcional(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
    }
}