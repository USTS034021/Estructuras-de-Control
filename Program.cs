using System;

namespace Estructurasdecontrol
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            menu();

        }

        static void menu()
        {
            int repetir_menu;

            Console.BackgroundColor = ConsoleColor.Black;

            System.Console.WriteLine("Estructuras de control en Visual C# :");

            System.Console.WriteLine("seleccione la opcion 1 para mostrar el Menú de opciones:");

            System.Console.WriteLine("seleccione la opcion 2. para Salir.");

            System.Console.WriteLine("seleccione la opcion 1 para mostrar el menú o el numero 2 para salir.");
            repetir_menu = Int32.Parse(Console.ReadLine());

            switch (repetir_menu)
            {
                case 1:
                    opciones();

                    break;
                case 2:
                    Environment.Exit(0);
                    System.Console.WriteLine("Usted ha decidido seleccionar salir!!!");

                    break;
                default:
                    System.Console.WriteLine("Opción que selecciono es incorrecta.");
                    break;
            }
            opciones();
        }


        static void opciones()
        {

            int opcion;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            System.Console.WriteLine("EJEMPLOS DE ESTRUCTURAS DE CONTROL:");
            System.Console.WriteLine("seleccione la opcion 1.para el USO DEL IF.");
            System.Console.WriteLine("seleccione la opcion 2.para el USO DEL WHILE.");
            System.Console.WriteLine("seleccione la opcion 3.para el USO DEL DOWHILE.");
            System.Console.WriteLine("seleccione la opcion 4.para el  USO DEL FOR. ");


            System.Console.WriteLine("seleccione la opción: ");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ejemplo_if();
                    break;
                case 2:
                    ejemplo_while();
                    break;
                case 3:
                    ejemplo_doWhile();
                    break;
                case 4:
                    ejemplo_for();
                    break;
                default:
                    System.Console.WriteLine(" la Opción que usted escribio no existe en nuestro sistema!!!");
                    break;
            }
            System.Console.ReadKey();
            //principal();

        }

        static void ejemplo_if()
        {
            System.Console.WriteLine("Ejemplo de IF:");
            Console.WriteLine("Ingrese un numero entre 1 y 3:");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine(" numero es 1.");
            }
            else
            if (num == 2)
            {
                Console.WriteLine("numero es 2.");
            }
            else
            if (num == 3)
            {
                Console.WriteLine("numero es 3.");
            }
            else
            {
                Console.WriteLine("el numero que usted escribio no fue encontrado.");
            }
            Console.ReadKey();

        }

        static void ejemplo_while()
        {
            System.Console.WriteLine("Ejemplo de while:");
            Console.WriteLine("escriba un numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba un numero mayor que el anterior.");
            int numero2 = int.Parse(Console.ReadLine());
            while (numero1 < numero2)
            {
                Console.WriteLine("valores:" + numero1);
                numero1++;
            }
            Console.ReadKey();
        }


        static void ejemplo_doWhile()
        {
            System.Console.WriteLine("Ejemplo de doWhile:");

            string secret;
            string programacion;
            Console.WriteLine("Introduzca la palabra secreta:");
            secret = Console.ReadLine();
            do
            {
                Console.WriteLine("Vuelva a introducir la palabra secreta:");
                programacion = Console.ReadLine();
                if (programacion != secret)
                    Console.WriteLine("Palabra incorrecta!!!");
            } while (programacion != secret);

            Console.WriteLine("Palabra Correcta.");
            Console.ReadKey();

        }

        static void ejemplo_for()
        {
            System.Console.WriteLine("Ejemplo de for:");

            {
                System.Console.WriteLine("Contador iniciado:");
                for (int num = 1; num <= 100; num++)
                {
                    Console.WriteLine(num);
                }

                Console.ReadLine();
            }
        }


    }
}