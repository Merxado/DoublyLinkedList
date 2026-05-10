namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            int opcion;

            do
            {
                Console.WriteLine("\n===== MENÚ =====");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Mostrar hacia adelante");
                Console.WriteLine("3. Mostrar hacia atrás");
                Console.WriteLine("4. Ordenar en orden descendente");
                Console.WriteLine("5. Mostrar la(s) moda(s)");
                Console.WriteLine("6. Mostrar gráfico de barras");
                Console.WriteLine("7. Buscar un valor");
                Console.WriteLine("8. Eliminar un valor");
                Console.WriteLine("9. Eliminar todos los nodos con un valor");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un valor: ");
                        string valor = Console.ReadLine();
                        list.Insert(valor);
                        break;
                    case 2:
                        list.PrintForward();
                        break;
                    case 3:
                        list.PrintBackward();
                        break;
                    case 4:
                        list.SortDescending();
                        Console.WriteLine("Lista ordenada en orden descendente.");
                        break;
                    case 5:
                        list.ShowMode();
                        break;
                    case 6:
                        list.ShowGraph();
                        break;
                    case 7:
                        Console.WriteLine("Ingrese el valor a buscar: ");
                        string buscar = Console.ReadLine();
                        if (list.Exists(buscar))
                            Console.WriteLine($"El valor '{buscar}' SI existe en la lista.");
                        else
                            Console.WriteLine($"El valor '{buscar}' NO existe en la lista.");
                        break;
                    case 8:
                        Console.WriteLine("Ingrese el valor: ");
                        string eliminar = Console.ReadLine();
                        list.RemoveOne(eliminar);
                        Console.WriteLine($"El valor '{eliminar}' ha sido eliminado (si existía).");
                        break;
                    case 9:
                        Console.WriteLine("Ingrese el valor: ");
                        string eliminarTodos = Console.ReadLine();
                        list.RemoveAll(eliminarTodos);
                        Console.WriteLine($"Todos los nodos con el valor '{eliminarTodos}' han sido eliminados.");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}


