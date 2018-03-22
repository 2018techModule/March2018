using System;

namespace Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            string health1 = new string('|', a1);
            string health2 = new string('.', a2 - a1);
            if (a1 == a2)
                Console.WriteLine($"Health: |{health1}|");
            else
                Console.WriteLine($"Health: |{health1}{health2}|");
            string energy1 = new string('|', b1);
            string energy2 = new string('.', b2 - b1);
            if (b1 == b2)
                Console.WriteLine($"Energy: |{energy1}|");
            else
                Console.WriteLine($"Energy: |{energy1}{energy2}|");
        }
    }
}
