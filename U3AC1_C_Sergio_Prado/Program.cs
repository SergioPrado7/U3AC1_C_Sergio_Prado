using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace U3AC1_C_Sergio_Prado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personalizar consola
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //Declarar los datos necesarios
            string nombreAlumno, materia, matricula, fechaNacimiento;
            byte calificacion, edad;
            //Mostrar los datos del usuario
            Console.WriteLine("PROGRAMA PARA SABER SU ACREDITACION DE UNA MATERIA \t (Al finalizar de teclear o digitar presionar ENTER)");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese su nombre completo:");
            nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingrese su marticula:");
            matricula = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento:");
            fechaNacimiento = Console.ReadLine(); 
            Console.WriteLine("Ingrese la materia cursada:");
            materia = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación que obtuvo en la materia antes cursada:");
            calificacion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\n");
            //Iniciando If
            if (calificacion >= 70)
            {
                Console.WriteLine("Usted a acreditado esta materia, ¡Felicidades!");
            }
            else 
            {
                Console.WriteLine("Usted no a acreditado esta materia, vuelva a cursarsarla");
            }
            Console.WriteLine("\n");
            //Saliendo de consola
            Console.WriteLine("Saliendo de consola.");
            Thread.Sleep(1500);
            Console.WriteLine("Saliendo de consola..");
            Thread.Sleep(1500);
            Console.WriteLine("Saliendo de consola...");
            Thread.Sleep(1500);
        }
    }
}
