namespace Application;

public class Utility2 : object
{
	/// <summary>
	/// Static Constructor
	/// Note: Access modifiers are not allowed on static constructors!
	/// </summary>
	static Utility2()
	{
	}

	public static int Sum(int a, int b)
	{
		var result = a + b;

		return result;
	}

	public Utility2() : base()
	{
	}
}
