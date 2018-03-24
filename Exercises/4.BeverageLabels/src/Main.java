import java.text.DecimalFormat;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.util.Locale;
import java.util.Scanner;
import javafx.event.*;


public class Main {
	public static Scanner input=new Scanner(System.in);
	
	public static void main(String args[]) {
		DecimalFormat df = new DecimalFormat("#.###");
		String name=input.nextLine();
		double volume=Double.parseDouble(input.nextLine());
		double energy=Double.parseDouble(input.nextLine());
		double sugar=Double.parseDouble(input.nextLine());
		System.out.printf("%sml %s: \n",df.format(volume),name);
		double b=volume*energy/100;
		double a=sugar*volume/100;
		System.out.printf("%skcal, %sg sugars",df.format(b),df.format(a));
	}
	
}