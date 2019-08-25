package corejava;

import static org.junit.Assert.assertEquals;

import java.util.Arrays;
import java.util.Collection;

import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;



@RunWith(Parameterized.class)
public class TestRecursion {
	
	private int inputNumber;
	private int exponent;
	private int result;
	private Recursions recursions;
	
	@Before
	public void initiliaze() {
		recursions = new Recursions();
	}
	
	
	public TestRecursion(Integer inputNumber, int result, int exponent) {
		this.inputNumber = inputNumber;
		this.exponent = exponent;
		this.result = result;
	}
	
	@Parameterized.Parameters
	public static Collection<Object[]> recursionNumbers() {
		return Arrays.asList(new Object[][]{
			{3,5},
			{4,24},
			{5,120},
			{2,2}			
		});
	}
	
	@Parameterized.Parameters
	public static Collection<Object[]> exponentiation() {
		return Arrays.asList(new Object[][]{
			{3,9,3},
			{4,16,4},
			{5,25,5},
			{2,2,2}			
		});
	}
	
	@Test
	public void testFactorial() {
		
		assertEquals(result,recursions.factorial(inputNumber));
	}
	
	@Ignore
	@Test
	public void testExponentiation() {
		
		assertEquals(result,recursions.exponentiation(inputNumber, exponent));
	}
	

}
