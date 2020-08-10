using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double res;
            string sig;

            Console.WriteLine("Seleccione su primera cifra: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Seleccione su operación: ");
            sig = Console.ReadLine();

            Console.Clear();

            switch (sig)
            {
                case "+":
                    Console.WriteLine("Usted está sumando");
                    break;
                case "-":
                    Console.WriteLine("Usted está restando");
                    break;
                case "/":
                    Console.WriteLine("Usted está dividiendo");
                    break;
                case "*":
                    Console.WriteLine("Usted está multiplicando");
                    break;
                default:
                    Console.WriteLine("Usted no a escogido bien su operación");
                    Console.ReadKey();
                    Console.WriteLine("Pulsar cualquier tecla para salir");
                    Console.ReadKey();
                    Environment.Exit(0);                                                
                    break;
            }
            Console.WriteLine("Seleccione su segunda cifra: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            //res = Convert.ToDecimal(Console.ReadLine());

            switch (sig)
            {
                case "+":
                    Console.WriteLine("El resultado en su suma de {0} y {1} es: ", num1, num2);
                    Console.WriteLine(res = num1 + num2);
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadKey();
                    break;
                case "-":
                    Console.WriteLine("El resultado en su resta de {0} y {1} es: ", num1, num2);
                    Console.WriteLine(res = num1 - num2);
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadKey();
                    break;
                case "/":
                    Console.WriteLine("El resultado en su división de {0} y {1} es: ", num1, num2);
                    Console.WriteLine(res = num1 / num2);
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadKey();
                    break;
                case "*":
                    Console.WriteLine("El resultado en su multiplicación de {0} y {1} es: ", num1, num2);
                    Console.WriteLine(res = num1 * num2);
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Syntax error");
                    break;
            }

        }
    }
}
