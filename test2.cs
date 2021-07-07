using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		var testClass = new TestClass();
		
		testClass.TestClassMethod();
	}
	
	public string TestMethod()
	{
		return "Hello";
	}
	
	public class TestClass
	{
		public string name = String.Empty;
		
		public void TestClassMethod()
		{
			Console.WriteLine(this.name);
		}
	}
}
