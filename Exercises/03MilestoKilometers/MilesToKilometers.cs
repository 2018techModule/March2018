using System;
					
public class Program
{
    public static void Main()
    {
        var mile = double.Parse(Console.ReadLine());
        
        var km = mile*1.60934;
		
        Console.WriteLine("{0:F2}",km);
    }
}