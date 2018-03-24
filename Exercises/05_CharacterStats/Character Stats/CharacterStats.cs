//confirmed from Maksim01
using System;

namespace Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)      // Main function
        {

            /* In the next 5 lines we recieve from the console the character name->string,
              current health,maximum healt,current energy,maximum energy : all integer*/
            string name = Console.ReadLine();                    
            int currentHealth = int.Parse(Console.ReadLine());    
            int maxHealth = int.Parse(Console.ReadLine());       
            int currentEnergy = int.Parse(Console.ReadLine());   
            int maxEnergy = int.Parse(Console.ReadLine());   
            
            //  TODO
            Console.WriteLine($"Name: {name}");        
            
            //In the next 2 lines we make 2 string ,which are in format : |||||...... (current health - max health).(1)
            string health1 = new string('|', currentHealth);
            string health2 = new string('.', maxHealth - currentHealth);
            //if they are equal we well print only the current health with | ,because its the same size as the maximum health
            if (currentHealth == maxHealth)
                Console.WriteLine($"Health: |{health1}|");
            //if they are not,then print them in the format we made in (1)
            else
                Console.WriteLine($"Health: |{health1}{health2}|");

            // Same thing for the energy as for the health
            string energy1 = new string('|', currentEnergy);
            string energy2 = new string('.', maxEnergy - currentEnergy);
            if (currentEnergy == maxEnergy)
                Console.WriteLine($"Energy: |{energy1}|");
            else
                Console.WriteLine($"Energy: |{energy1}{energy2}|");
        }
    }
}
