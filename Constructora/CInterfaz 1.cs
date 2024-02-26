using System;
using System.Collections;

namespace SegundoParcial
{
    public class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static string DarOpcion()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("*                Sistema de Gestión de Empresa           *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("\n[A]     Establecer e informar las variables de sueldos.");
            Console.WriteLine("\n[B]     Registrar un empleado.");
            Console.WriteLine("\n[C]     Listar los datos completos de todos los empleados de la empresa.");
            Console.WriteLine("\n[D]     Registrar una obra con un código único y todos sus datos.");
            Console.WriteLine("\n[E]     Modificar el profesional designado como supervisor de una obra.");
            Console.WriteLine("\n[F]     Asignar un obrero en una obra.");
            Console.WriteLine("\n[H]     Listar los datos completos de todos los empleados de una obra.");
            Console.WriteLine("\n[I]     Eliminar un profesional de la empresa.");
            Console.WriteLine("\n[S]     Salir de la aplicación.");
            Console.WriteLine("\n********************************************************");
            return CInterfaz.PedirDato("opción elegida");
        }
        public static string PedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + "es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
        }

        public static void MostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
