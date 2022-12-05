using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arbol_Binario;
using static System.Net.Mime.MediaTypeNames;

CArbolBB arbol = new CArbolBB();

bool flag = false;
CNodo raiz= new CNodo();

while (true)
{
    Console.WriteLine("Elige una de las opciones introduciendo el número correspondiente");
    Console.WriteLine(" ");
    Console.WriteLine("Insertar Nodo     --------------------- 1");
    Console.WriteLine("Buscar            --------------------- 2");
    Console.WriteLine("Buscar Padre      --------------------- 3");
    Console.WriteLine("Buscar el mínimo  --------------------- 4");
    Console.WriteLine("Imprimir          --------------------- 5");
    Console.WriteLine(" ");
    Console.WriteLine("Salir             --------------------- 6");
    Console.WriteLine(" ");
    Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - ");
    Console.WriteLine(" ");


    switch (Console.ReadLine())
    {
        case "1":
            string respuesta = "si";

            while (respuesta == "si")
            {
                if (flag == false)
                {
                    Console.WriteLine("Introduce un número:");
                    int a = Int16.Parse(Console.ReadLine());
                    raiz = arbol.Insertar(a, null);
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Introduce un número:");
                    int x = Int16.Parse(Console.ReadLine());
                    arbol.Insertar(x, raiz);
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("Deseas añadir otro número? (si) (no)");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - ");
            break;

        case "2":
            string respuesta2 = "si";
            while (respuesta2 == "si")
            {
                Console.WriteLine("Introduce el número que quieres buscar:");
                int b = Int16.Parse(Console.ReadLine());
                Console.WriteLine(arbol.Buscar(b, raiz).Existo);

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("Deseas buscar otro número? (si) (no)");
                respuesta2 = Console.ReadLine();
            }


            break;

        case "3":

            string respuesta3 = "si";
            while (respuesta3 == "si")
            {
                Console.WriteLine("Introduce un número para buscar su padre:");
                int c = Int16.Parse(Console.ReadLine());
                Console.WriteLine("El padre es:");
                Console.WriteLine(arbol.BuscarPadre(c, raiz).Dato);

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("Deseas buscar el padre de otro número? (si) (no)");
                respuesta3 = Console.ReadLine();
            }

            break;

        case "4":
            Console.WriteLine("El mínimo es:");
            Console.WriteLine(arbol.EncuentraMinimo(raiz));

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Presiona enter para salir.");
            Console.ReadLine();
            break;

        case "5":
            Console.WriteLine(" ");
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - ");
            arbol.Transversa(raiz);

            Console.WriteLine("Presiona enter para salir.");
            Console.ReadLine();
            break;

        case "6":
            Environment.Exit(0);
            break;


        default:
            Console.WriteLine("La opción seleccionada no existe.");
            Console.WriteLine("Por favor, Introduzca una opción válida.");
            break;
    }
    Console.Clear();
}



