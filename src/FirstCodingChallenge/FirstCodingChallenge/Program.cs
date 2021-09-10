using System;

namespace FirstCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<string> sl = new SinglyLinkedList<string>();
            sl.Add("Tom");
            sl.Add("Bob");
            sl.Add("Alice");
            sl.Add("Jack");
            sl.Insert("1", 2);
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }

            sl.Remove("Bob");
            Console.WriteLine("\n После удаления: \n");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }
        }
    }
}
