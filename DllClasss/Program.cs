using System;

namespace DllClasss
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.Add(3);
            dll.Add(5);
            dll.Add(9);
            dll.Add(10);
            dll.printIndo();
            // dll.Reverse();
            // dll.printIndo();
            dll.Remove(10);
            dll.printIndo();
            Console.WriteLine("------------------------------------------- ");
            dll.Remove(10);
            dll.printIndo();
            Console.WriteLine("------------------------------------------- ");
            dll.Remove(3);
            dll.printIndo();
            Console.WriteLine("------------------------------------------- ");
            dll.Remove(9);
            dll.printIndo();
            Console.WriteLine("------------------------------------------- ");
            dll.Remove(5);
            dll.printIndo();
            Console.WriteLine("------------------------------------------- ");

        }
    }
}
