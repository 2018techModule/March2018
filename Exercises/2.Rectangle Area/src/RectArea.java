import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class RectArea {

	public static void main(String[] args) throws IOException  {
		//Start reading from the console: Rectangle's width and rectangle's height.
                BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
		double width = Double.parseDouble(input.readLine());
		double height = Double.parseDouble(input.readLine());
		
                //Calculating Rectangle's Area.
		System.out.printf("%.2f", width*height);
		
	}

}
