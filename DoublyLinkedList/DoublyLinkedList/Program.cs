class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();

        list.Insert("Blanco");
        list.Insert("Azul");
        list.Insert("Amarillo");
        list.Insert("Verde");
        list.Insert("Negro");

        list.PrintForward();
        list.PrintBackward();

        list.Remove("Amarillo");
        list.PrintForward();
    }
}
