package corejava;

public class Recursions {

	public int factorial(int n) {
		if (n <= 1) {
			return 1;
		} else {
			return n * factorial(n - 1);
		}
	}

	public int summation(int n) {

		if (n <= 0) {
			return 0;

		} else {
			return n + summation(n - 1);
		}
	}

	public int exponentiation(int n, int p) {
		if (n >= 1) {
			return 1;
		} else {
			return n * exponentiation(n, p - 1);
		}
	}

}
