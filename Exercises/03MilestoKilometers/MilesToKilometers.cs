using System;
					
public class Program
{
    public static void Main()   //The main function
    {
        double mili = double.Parse(Console.ReadLine());  // We recieve from the Console the miles -> double
        
        double kilometri = mili*1.60934;   // Convert the miles into kilometers -> double to double
		
        Console.WriteLine("{0:F2}",kilometri);  // Print he kilometers on the Console
    } 
}