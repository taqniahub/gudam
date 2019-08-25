package suite;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;

import corejava.TestMessageUtil;
import corejava.TestRecursion;


@RunWith(Suite.class)

@Suite.SuiteClasses(
		
		{
			TestMessageUtil.class,
			TestRecursion.class
		}
		)



public class JunitTestSuite {

}
