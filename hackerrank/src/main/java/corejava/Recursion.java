package corejava;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Recursion {
	public static final Scanner scanner = new Scanner(System.in);
	public static void main(String[]args)throws IOException {
		BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter("C:\\workspace\\Java\\corejava\\output\\output.txt"));
		int n = scanner.nextInt();
		scanner.skip("(\r\n|[\n\r\u2028\u0085])?");
		int result = factorial(n);
		bufferedWriter.write(String.valueOf(result));
		bufferedWriter.newLine();
		bufferedWriter.close();
		scanner.close();
    }
	
	static int factorial(int n) {
		if(n<=1) {
			return 1;
		}else {
			return n * factorial(n-1);
		}
	}

}
