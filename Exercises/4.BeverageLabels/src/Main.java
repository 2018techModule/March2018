//CONFIRMED from ValTod
//CONFIRMED from ValTod second time after variables changes
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
//Read parameters about drink from the console
		double volumes=Double.parseDouble(input.nextLine());
		double energy=Double.parseDouble(input.nextLine());
		double sugar=Double.parseDouble(input.nextLine());
//Calculate and print information about calories
		System.out.printf("%sml %s: \n",df.format(volume),name);
		double b=volume*energy/100;
		double a=sugar*volume/100;
		System.out.printf("%skcal, %sg sugars",df.format(b),df.format(a));
	}
	
}
