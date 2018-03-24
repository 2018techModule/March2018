using System;

namespace Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            string health1 = new string('|', currentHealth);
            string health2 = new string('.', maxHealth - currentHealth);
            if (currentHealth == maxHealth)
                Console.WriteLine($"Health: |{health1}|");
            else
                Console.WriteLine($"Health: |{health1}{health2}|");
            string energy1 = new string('|', currentEnergy);
            string energy2 = new string('.', maxEnergy - currentEnergy);
            if (currentEnergy == maxEnergy)
                Console.WriteLine($"Energy: |{energy1}|");
            else
                Console.WriteLine($"Energy: |{energy1}{energy2}|");
        }
    }
}
