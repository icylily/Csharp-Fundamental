using System;

namespace SllClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.Add(5);
            sll.Add(7);
            sll.Add(0);
            sll.PrintValues();
            Console.WriteLine(sll.Find(0));
        }
    }
}
