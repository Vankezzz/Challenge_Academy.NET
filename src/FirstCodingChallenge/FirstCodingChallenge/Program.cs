using System;

namespace FirstCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> sl = new SinglyLinkedList<int>();
            sl.Add(1);
            sl.Add(2);
            sl.Add(3);
            sl.Add(4);
            sl.Insert(3, 2);
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }

            sl.Remove(1);
            Console.WriteLine("\n After deleting: \n");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }
        }
    }
}
