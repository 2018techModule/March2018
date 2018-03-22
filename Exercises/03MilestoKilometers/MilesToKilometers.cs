using System;
					
public class Program
{
    public static void Main()
    {
        double mili = double.Parse(Console.ReadLine());
        
        double kilometri = mili*1.60934;
		
        Console.WriteLine("{0:F2}",kilometri);
    }
}