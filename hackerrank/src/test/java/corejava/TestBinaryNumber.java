package corejava;

import static org.junit.Assert.assertEquals;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;

import org.junit.Test;


public class TestBinaryNumber {
	
	BinaryNumber bn = new BinaryNumber();
	int number = 5;
	
	@Test	
	public void testConsecutiveOne() {
		
		HashMap<Integer,Integer> hMap = new HashMap<Integer,Integer>();
		//hMap.put(1,0);
		//hMap.put(2,1);
		//hMap.put(3,1);
		//hMap.put(4,1);
		hMap.put(5,1);
		hMap.put(6,2);
		hMap.put(7,3);
		hMap.put(8,1);
		hMap.put(9,1);
		hMap.put(15,4);
		hMap.put(14,3);
		hMap.put(31,5);
		
		//Set entrySet = hMap.entrySet();
		//Iterator it = entrySet.iterator();
		//while(it.hasNext()) {
			//Map.Entry me = (Map.Entry)it.next();
			//int expected = (Integer) me.getKey();
			//int actual = (Integer)me.getValue();
			assertEquals(1,bn.consecutiveOne(1));
			assertEquals(1,bn.consecutiveOne(2));
			assertEquals(2,bn.consecutiveOne(3));
			assertEquals(1,bn.consecutiveOne(4));
			assertEquals(1,bn.consecutiveOne(5));
			assertEquals(2,bn.consecutiveOne(6));
			assertEquals(3,bn.consecutiveOne(7));
		//}
		
	}

}