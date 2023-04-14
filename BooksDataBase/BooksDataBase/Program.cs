using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarEnArray
{
    class Program
    {
        static void Main(string[] args)
        {

          
            string[] array = new string[1000];
            
            menu();

            void menu()
            {
                string seleccionar;

                Console.WriteLine("Seleccione el tipo de dato que quiere añadir de su libro: ");
                Console.WriteLine("1.Añadir Título.");
                Console.WriteLine("2.Mostrar Lista de libros Añadida.");
                Console.WriteLine("3.Buscar libros mediante título.");
                Console.WriteLine("4.Borrar libro en función de su posición.");
                Console.WriteLine("5.Salir del programa.");
                seleccionar = Console.ReadLine();

                switch (seleccionar)
                {
                    case "1":

                        addtitulo();
                        menu();
                        break;

                    case "2":

                        mostrarlista();
                        menu();
                        break;

                    case "3":

                        buscar();
                        menu();
                        break;

                    case "4":

                        deleteposicion();
                        menu();
                        break;

                    case "5":

                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Por favor, introduce una opción válida.");
                        menu();
                        break;

                }
            }

            void addtitulo()
            {
                int n;
                Console.WriteLine("¿Cuantos libros vas a añadir?");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {

                    if (n > 999)
                    {
                        Console.WriteLine("Máximo de libros soportados 1000, por favor, añada un número menor.");
                        addtitulo();
                    }
                    else
                    {
                        Console.WriteLine($"El titulo del libro que quieras introducir:");
                         array[i] = Console.ReadLine();
                    }
                }
            }
            
            
            void mostrarlista()
            {

                foreach (string i in array)
                {
                    Console.WriteLine(i);
                    
                   if ( i == null)
                    {
                        menu();
                    }

                }
            }
            void buscar()
            {
                bool encontrado = false;


                Console.WriteLine("Introduce el título del libro que desea buscar: ");
                string librobuscado = (Console.ReadLine());
                for (int i = 0; i < 1000; i++)
                {
                    if (array[i] == librobuscado)
                    {
                        encontrado = true;
                        break;
                    }


                }

                if (encontrado == true)
                {
                    Console.WriteLine($"El libro {librobuscado} se encuentra en la lista");
                }
                else
                {
                    Console.WriteLine($"El libro {librobuscado} no se encuentra en la lista");
                }

                Console.WriteLine("Presiona cualquier tecla para ir al menú");
                Console.ReadKey();
                


            }
            void deleteposicion()
            {

                int TituloBorrar = 0;

                array = array.Where((source, index) => index != TituloBorrar).ToArray();
                Console.WriteLine("Indique la posición del libro que quiere borrar");
                TituloBorrar = int.Parse(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine("Elemento borrado... La lista de libros resultante es la siguiente ");

                foreach (string libro in array)
                {
                    Console.WriteLine(libro);

                    if (libro == null)
                    {
                        menu();
                    }
                } 
             
            }

        }

    }
}
    