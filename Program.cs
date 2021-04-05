using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Lea las teclas presionadas y finalice al presionar Ctrl+F (Ctrl y F al mismo tiempo)
            ConsoleKeyInfo tecla;
            do
            {
                Console.WriteLine("Ingrese las letras presionadas.");
                char letra = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Usteed ha presionado la tecla " + letra);
                Console.WriteLine("Para finalizar presione  Ctrl+F al mismo tiempo");
                tecla = Console.ReadKey(true);
                if (((tecla.Modifiers & ConsoleModifiers.Control) != 0) &&
                    (tecla.Key == ConsoleKey.F))
                {
                    break;
                }
            } while (true);
        }
    }
}
