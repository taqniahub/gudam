package corejava;

import static org.junit.Assert.assertEquals;

import org.junit.Ignore;
import org.junit.Test;

public class TestMessageUtil {
	String message = "Hello World";
	MessageUtil messageUtil =  new MessageUtil(message);
	
	@Ignore
	@Test
	public void testDisplayMessage() {
		assertEquals(message,messageUtil.displayMessage());
	}

}
